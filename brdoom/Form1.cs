using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// O parametro abaixo é necessário para iniciar programas externos
using System.Diagnostics;

namespace BrDOOM
{
    public partial class Form1 : Form
    {
        // Variáveis principais
        private String iwad;
        private String warp;
        private String totalParameters;
        private String sourceport;
        private String extraOptions;
        private String getEngine;
        private String getParameters;
        private int getValor;
        private int gamemode;
        private int skill;
        //private String startGame;
    
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Função para encerrar a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Função para iniciar o sourceport com as opções escolhidas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            StartGame playNow = new StartGame();

            // Validação básica ^^
            // Seleção do IWAD
            if (rbIwadDoom.Checked == false && rbIwadDoom2.Checked == false && rbIwadTnt.Checked == false && rbIwadPlutonia.Checked == false && rbIwadHeretic.Checked == false && rbIwadHexen.Checked == false)
            {
                MessageBox.Show("Você deve selecionar um IWAD!");
            }
            // Seleção do nível de dificuldade
            else if (rbSkillExtraFacil.Checked == false && rbSkillFacil.Checked == false && rbSkillNormal.Checked == false && rbSkillDificil.Checked == false && rbSkillImpossivel.Checked == false)
            {
                MessageBox.Show("Você deve selecionar o nível de dificuldade!");
            }
            // Seleção do modo de jogo
            else if (rbSinglePlayer.Checked == false && rbDeathMatch.Checked == false && rbCooperative.Checked == false)
            {
                MessageBox.Show("Você deve selecionar um modo de jogo!");
            }
            else
            {
                // Seleção do LevelWarp
                if (txtLevelWarp.Text != "")
                {
                    warp = txtLevelWarp.Text;
                }

                // Passagem de parametros para o processo de carregamento do port
                // A ordem a ser seguida está listada abaixo
                // SourcePort, IWAD, Dificuldade, GameMode, LevelWarp
                getEngine = "skulltag";
                getParameters = " -iwad " + iwad + " -skill " + skill + " " + gamemode + " -warp " + warp + extraOptions;
                getValor = playNow.runGame(getEngine, getParameters);

                //try
                //{
                //    playNow.runGame(totalParameters);
                //}
                //catch (Exception error)
                //{
                //    MessageBox.Show(error.ToString());
                //}

                if (getValor == 1)
                {
                    MessageBox.Show("Não foi possível iniciar o programa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Debug besta =P
              //  MessageBox.Show(totalParameters);
            }
            //MessageBox.Show(mtbIpAddress.Text);
        }

        /// <summary>
        /// Função do formulário para carregamento automático
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            EnableDisableHostOptions(0);
        }

        /// <summary>
        /// Funções para seleção do modo de jogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void rbCooperative_CheckedChanged(object sender, EventArgs e)
        {
            gamemode = 1;
        }

        private void rbSinglePlayer_CheckedChanged(object sender, EventArgs e)
        {
            gamemode = 2;
        }

        private void rbDeathMatch_CheckedChanged(object sender, EventArgs e)
        {
            gamemode = 3;
        }

        /// <summary>
        /// Função para Reset de todas as opções
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefault_Click(object sender, EventArgs e)
        {
            resetAllOptions();
        }

        /// <summary>
        /// Funções para seleção do nível de dificuldade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbSkillExtraFacil_CheckedChanged(object sender, EventArgs e)
        {
            skill = 1;
        }

        private void rbSkillFacil_CheckedChanged(object sender, EventArgs e)
        {
            skill = 2;
        }

        private void rbSkillNormal_CheckedChanged(object sender, EventArgs e)
        {
            skill = 3;
        }

        private void rbSkillDificil_CheckedChanged(object sender, EventArgs e)
        {
            skill = 4;
        }

        private void rbSkillImpossivel_CheckedChanged(object sender, EventArgs e)
        {
            skill = 5;
        }

        /// <summary>
        /// Funções para seleção do IWAD a ser usado/jogado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbIwadDoom_CheckedChanged(object sender, EventArgs e)
        {
            iwad = "doom.wad";
        }

        private void rbIwadDoom2_CheckedChanged(object sender, EventArgs e)
        {
            iwad = "doom2.wad";
        }

        private void rbIwadTnt_CheckedChanged(object sender, EventArgs e)
        {
            iwad = "tnt.wad";
        }

        private void rbIwadPlutonia_CheckedChanged(object sender, EventArgs e)
        {
            iwad = "plutonia.wad";
        }

        private void rbIwadHeretic_CheckedChanged(object sender, EventArgs e)
        {
            iwad = "heretic.wad";
        }

        private void rbIwadHexen_CheckedChanged(object sender, EventArgs e)
        {
            iwad = "hexen.wad";
        }

        /// <summary>
        /// Habilita/Desabilita opções do host
        /// 
        /// Valores possíveis são 1 e 0
        /// 1 - Habilitar 
        /// 0 - Desabilitar
        /// </summary>
        /// <param name="valor"></param>
        private void EnableDisableHostOptions(int valor)
        {
            if (valor == 1)
            {
                mtbPlayers.Enabled = true;
                mtbFragLimit.Enabled = true;
                mtbTimeLimit.Enabled = true;
                mtbIpAddress.Enabled = true;
            }
            else
            {
                mtbPlayers.ResetText();
                mtbFragLimit.ResetText();
                mtbTimeLimit.ResetText();
                mtbIpAddress.ResetText();
                mtbPlayers.Enabled = false;
                mtbFragLimit.Enabled = false;
                mtbTimeLimit.Enabled = false;
                mtbIpAddress.Enabled = false;
            }
        }

        /// <summary>
        /// Reset de todas as opções
        /// </summary>
        private void resetAllOptions()
        {
            // Reset da aba Server
            cbHost.Checked = false;
            EnableDisableHostOptions(0);

            // Reset dos valores dos radiobutton - IWAD
            rbIwadDoom.Checked = false;
            rbIwadDoom2.Checked = false;
            rbIwadTnt.Checked = false;
            rbIwadPlutonia.Checked = false;
            rbIwadHeretic.Checked = false;
            rbIwadHexen.Checked = false;

            // Reset dos valores dos radiobutton - Skill
            rbSkillExtraFacil.Checked = false;
            rbSkillFacil.Checked = false;
            rbSkillNormal.Checked = false;
            rbSkillDificil.Checked = false;
            rbSkillImpossivel.Checked = false;

            // Reset dos valores dos radiobutton - GameType
            rbSinglePlayer.Checked = false;
            rbDeathMatch.Checked = false;
            rbCooperative.Checked = false;

            // Reset do conteúdo do LevelWarp
            txtLevelWarp.ResetText();

            // Reset do conteúdo do textbox - Command Line
            txtCommandLine.ResetText();
        }

        /// <summary>
        /// Função para seleção do mapa à ser jogado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLevelWarp_TextChanged(object sender, EventArgs e)
        {
            if (txtLevelWarp.Text != "")
            {
                warp = txtLevelWarp.Text;
            }
            else
            {
                warp = " ";
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myAbout myboutok = new myAbout();
            myboutok.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but this feature has not yet been implemented!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but this feature has not yet been implemented!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, but this feature has not yet been implemented!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Função para habilitar/desabilitar a opção servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHost_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHost.Checked)
            {
                EnableDisableHostOptions(1);
            }
            else
            {
                EnableDisableHostOptions(0);
            }
        }

        /// <summary>
        /// Funções extras para o servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAltDeath_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAltDeath.Checked)
            {
                extraOptions = "-altdeath";
            }
            else
            {
                extraOptions = " ";
            }
        }

        private void cbNoMonters_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoMonsters.Checked)
            {
                extraOptions = "-nomonsters";
            }
            else
            {
                extraOptions = " ";
            }
        }

        private void cbNoMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoMouse.Checked)
            {
                extraOptions = "-nomouse";
            }
            else
            {
                extraOptions = " ";
            }
        }

        private void cbNoMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoMusic.Checked)
            {
                extraOptions = "-nomusic";
            }
            else
            {
                extraOptions = " ";
            }
        }

        private void cbNoSfx_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoSfx.Checked)
            {
                extraOptions = "-nosfx";
            }
            else
            {
                extraOptions = " ";
            }
        }

        private void cbNoSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoSound.Checked)
            {
                extraOptions = "-nosound";
            }
            else
            {
                extraOptions = " ";
            }
        }

        private void cbOldDeathmatch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOldDeathmatch.Checked)
            {
                extraOptions = "-deathmatch";
            }
            else
            {
                extraOptions = " ";
            }
        }

        private void txtCommandLine_TextChanged(object sender, EventArgs e)
        {
            extraOptions = txtCommandLine.Text;
        }

    }
}
