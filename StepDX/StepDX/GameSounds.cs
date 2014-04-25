using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;
using System.Media;

namespace StepDX
{
    class GameSounds
    {
        System.IO.Stream jump;
        System.IO.Stream die;
        System.IO.Stream gameover;
        System.IO.Stream gamewon;
        System.IO.Stream kick;

        SoundPlayer player;

        System.Reflection.Assembly assembly; 

        public GameSounds(Form form)
        {
            assembly = System.Reflection.Assembly.GetExecutingAssembly();
        }

        public void Jump()
        {
            jump = assembly.GetManifestResourceStream("StepDX.jump.wav");
            player = new SoundPlayer(jump);
            player.Play();
        }

        public void Die()
        {
            die = assembly.GetManifestResourceStream("StepDX.mariodie.wav");
            player = new SoundPlayer(die);
            player.Play();
        }

        public void GameOver()
        {
            gameover = assembly.GetManifestResourceStream("StepDX.die.wav"); 
            player = new SoundPlayer(gameover);
            player.Play();
        }

        public void GameWon()
        {
            gamewon = assembly.GetManifestResourceStream("StepDX.stage_clear.wav");
            player = new SoundPlayer(gamewon);
            player.Play();
        }

        public void Kick()
        {
            kick = assembly.GetManifestResourceStream("StepDX.kick.wav");
            player = new SoundPlayer(kick);
            player.Play();
        }
    }
}