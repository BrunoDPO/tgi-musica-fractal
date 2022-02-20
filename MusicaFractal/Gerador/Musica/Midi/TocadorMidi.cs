using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gerador.Musica.Midi
{
    public class TocadorMidi
    {
        [DllImport("winmm.dll")]
        static extern int midiOutOpen(ref int lphMidiOut, int uDeviceID, int dwCallback, int dwInstance, UInt32 dwFlags);

        [DllImport("winmm.dll")]
        static extern int midiOutShortMsg(int hMidiOut, UInt32 dwMsg);

        [DllImport("winmm.dll")]
        static extern int midiOutReset(int hMidiOut);

        [DllImport("winmm.dll")]
        static extern int midiOutClose(int hMidiOut);

        private static byte NOTE_ON = 0x90;
        private static byte NOTE_OFF = 0x80;

        private int hMidi = 0;

        public void Tocar(NotaMusical[] notas, double tempo)
        {
            midiOutOpen(ref hMidi, 0 /* Device ID */, 0, 0, 0);

            byte[] data = new byte[4];
            // [0] = voice message
            // [1] = status
            // [2] = data 1
            // [3] = data 2 (unused)

            for (int i = 0; i < notas.Length; i++)
            {
                UInt32 msg;
                // Desativa alguma nota que esteja tocando
                data[0] = NOTE_OFF;
                msg = BitConverter.ToUInt32(data, 0);
                midiOutShortMsg(hMidi, msg);

                // Toca a nota
                data[0] = NOTE_ON;
                data[1] = notas[i].ToMIDI();    // nota
                data[2] = 100;                  // volume
                msg = BitConverter.ToUInt32(data, 0);
                midiOutShortMsg(hMidi, msg);

                Thread.Sleep(Convert.ToInt32(Math.Floor(CalcularIntervalo(notas[i].Duracao, tempo))));
            }
            midiOutReset(hMidi);
            midiOutClose(hMidi);
        }

        private static double CalcularIntervalo(Duracao duracao, double tempo)
        {
            double duracaoSeminima = 60000 / tempo;
            if (duracao == Duracao.Semifusa)
                return duracaoSeminima / 16;
            if (duracao == Duracao.Fusa)
                return duracaoSeminima / 8;
            if (duracao == Duracao.Semicolcheia)
                return duracaoSeminima / 4;
            if (duracao == Duracao.Colcheia)
                return duracaoSeminima / 2;
            if (duracao == Duracao.Semínima)
                return duracaoSeminima;
            if (duracao == Duracao.Mínima)
                return duracaoSeminima * 2;
            //if (duracao == Duracao.Semibreve)
            return duracaoSeminima * 4;
        }
    }
}
