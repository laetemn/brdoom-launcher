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
            // Seleção do sourceport
            if (cbSourcePort.Text == "Selecione...")
            {
                MessageBox.Show("Você deve selecionar um sourceport!");
            }
            // Seleção do IWAD
            else if (rbIwadDoom.Checked == false && rbIwadDoom2.Checked == false && rbIwadTnt.Checked == false && rbIwadPlutonia.Checked == false && rbIwadHeretic.Checked == false && rbIwadHexen.Checked == false)
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
                totalParameters = sourceport + " -iwad " + iwad + " " + skill + " " + gamemode + " " + warp;
                getValor = playNow.runGame(totalParameters);
                if (getValor == 1)
                {
                    MessageBox.Show("Não foi possível iniciar o programa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Debug besta =P
                MessageBox.Show(totalParameters);
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

            // Reset do conteúdo do combobox - SourcePort
            cbSourcePort.ResetText();
            cbSourcePort.Text = "Selecione...";

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
            warp = txtLevelWarp.Text;
        }

        /// <summary>
        /// Função combobox para seleção do sourceport à ser utilizado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSourcePort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSourcePort.Text)
            {
                case "ATB Doom (Legado)":
                    sourceport = "atb";
                    break;
                case "BZDoom (Legado)":
                    sourceport = "bzdoom";
                    break;
                case "CGDoom (Legado)":
                    sourceport = "cgdoom";
                    break;
                case "Chocolate Doom":
                    sourceport = "chocodoom";
                    break;
                case "csDoom (Legado)":
                    sourceport = "csdoom";
                    break;
                case "Doom 3D (Legado)":
                    sourceport = "doom3d";
                    break;
                case "Doom64 EX":
                    sourceport = "doom64ex";
                    break;
                case "DoomGL (Legado)":
                    sourceport = "doomgl";
                    break;
                case "Doom Legacy":
                    sourceport = "legacy";
                    break;
                case "Doom Plus (Legado)":
                    sourceport = "doomplus";
                    break;
                case "Doomsday":
                    sourceport = "doomsday";
                    break;
                case "EDGE (Legado)":
                    sourceport = "edge";
                    break;
                case "Eternity Engine (Legado)":
                    sourceport = "eternity";
                    break;
                case "glBoom (Legado)":
                    sourceport = "glboom";
                    break;
                case "GZDoom":
                    sourceport = "gzdoom";
                    break;
                case "IA SDoom (Legado)":
                    sourceport = "iasdoom";
                    break;
                case "Mocha Doom (Legado)":
                    sourceport = "mochadoom";
                    break;
                case "Odamex":
                    sourceport = "odamex";
                    break;
                case "Power Doom (Legado)":
                    sourceport = "pwdoom";
                    break;
                case "PrBoom (Legado)":
                    sourceport = "prboom";
                    break;
                case "PrBoom+ (Legado)":
                    sourceport = "prboom+";
                    break;
                case "ReMooD":
                    sourceport = "remood";
                    break;
                case "Risen3D":
                    sourceport = "risen3d";
                    break;
                case "SkullTag":
                    sourceport = "skulltag";
                    break;
                case "Smack My Marine Up (Legado)":
                    sourceport = "smmu";
                    break;
                case "Vavoom (Legado)":
                    sourceport = "vavoom";
                    break;
                case "WDMP (Legado)":
                    sourceport = "wdmp";
                    break;
                case "Win32 Doom (Legado)":
                    sourceport = "w32doom";
                    break;
                case "WinDoom (Legado)":
                    sourceport = "windoom";
                    break;
                case "WinMBF (Legado)":
                    sourceport = "winmbf";
                    break;
                case "ZDaemon":
                    sourceport = "zdaemon";
                    break;
                case "ZDoom":
                    sourceport = "zdoom";
                    break;
                case "ZDoomGL (Legado)":
                    sourceport = "zdoomgl";
                    break;
            }
            //sourceport = cbSourcePort.Text;
        }


    }
}
