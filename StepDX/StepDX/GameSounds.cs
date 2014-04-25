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
            jump = assembly.GetManifestResourceStream("StepDX.jump.wav");
            die = assembly.GetManifestResourceStream("StepDX.mariodie.wav");
            gameover = assembly.GetManifestResourceStream("StepDX.die.wav"); 
            gamewon = assembly.GetManifestResourceStream("StepDX.stage_clear.wav");
            kick = assembly.GetManifestResourceStream("StepDX.kick.wav");

        }

        public void Jump()
        {
            player = new SoundPlayer(jump);
            player.Play();
        }

        public void Die()
        {
            player = new SoundPlayer(die);
            player.Play();
        }

        public void GameOver()
        {
            player = new SoundPlayer(gameover);
            player.Play();
        }

        public void GameWon()
        {
            player = new SoundPlayer(gamewon);
            player.Play();
        }

        public void Kick()
        {
            player = new SoundPlayer(kick);
            player.Play();
        }
    }
}