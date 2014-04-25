using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;

using System.Reflection;
using System.IO;

namespace StepDX
{
    class GameSounds
    {
        private Device SoundDevice = null;

        private SecondaryBuffer jump = null;
        private SecondaryBuffer die = null;
        private SecondaryBuffer gameend = null;
        private SecondaryBuffer gamewon = null;
        private SecondaryBuffer kick = null;

        public GameSounds(Form form)
        {
            SoundDevice = new Device();
            SoundDevice.SetCooperativeLevel(form, CooperativeLevel.Priority);
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();

            Load(ref jump, assembly.GetManifestResourceStream("StepDX.jump.wav"));
            Load(ref die, assembly.GetManifestResourceStream("StepDX.mariodie.wav"));
            Load(ref gameend, assembly.GetManifestResourceStream("StepDX.die.wav"));
            Load(ref gamewon, assembly.GetManifestResourceStream("StepDX.stage_clear.wav"));
            Load(ref kick, assembly.GetManifestResourceStream("StepDX.kick.wav"));
        }

        private void Load(ref SecondaryBuffer buffer, Stream stream)
        {
            try
            {
                buffer = new SecondaryBuffer(stream, SoundDevice);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load " + stream,
                                "Danger, Will Robinson", MessageBoxButtons.OK);
                buffer = null;
            }
        }

        public void Jump()
        {
            if (jump == null)
                return;

            if (!jump.Status.Playing)
                jump.Play(0, BufferPlayFlags.Default);
        }

        public void Die()
        {
            if (die == null)
                return;

            if (!die.Status.Playing)
                die.Play(0, BufferPlayFlags.Default);
        }

        public void GameOver()
        {
            if (gameend == null)
                return;

            if (!gameend.Status.Playing)
                gameend.Play(0, BufferPlayFlags.Default);
        }

        public void GameWon()
        {
            if (gamewon == null)
                return;

            if (!gamewon.Status.Playing)
                gamewon.Play(0, BufferPlayFlags.Default);
        }

        public void Kick()
        {
            if (kick == null)
                return;

            if (!kick.Status.Playing)
                kick.Play(0, BufferPlayFlags.Default);
        }
    }
}