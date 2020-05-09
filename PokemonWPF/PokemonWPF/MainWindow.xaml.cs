﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PokemonDAL;

namespace PokemonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> menuElements = new List<string>();
        public Trainer trainer = DatabaseOperations.SelectTrainer(2);

        public MainWindow()
        {
            InitializeComponent();
            menuElements.Add("Pokedex");
            menuElements.Add("Party");
            menuElements.Add("Inventory");
            menuElements.Add(trainer.TrainerName);
            menuElements.Add("Exit");



            lbMenu.ItemsSource = menuElements;
        }

        private void lbMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (lbMenu.SelectedIndex)
            {
                case 0: txbInfo.Text = "A encyclopedia of all seen pokemon";
                    break;

                case 1:
                    txbInfo.Text = "Access your party screen";
                    break;
                case 2:
                    txbInfo.Text = $"Show inventory of {trainer.TrainerName}";
                    break;
                case 3:
                    txbInfo.Text = $"Show the trainercard of {trainer.TrainerName}";
                    break;
                default:  txbInfo.Text = "Close the program";
                    break;
            }
        }

        private void lbMenu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch (lbMenu.SelectedIndex)
            {
                case 0:
                    this.Visibility = Visibility.Hidden;
                    PokédexWindow pokédexWindow1 = new PokédexWindow();
                    pokédexWindow1.WindowToAlter = this;
                    pokédexWindow1.Show();




                    break;
                case 1:
                    
                    PokemonParty partyscreen = new PokemonParty();
                    partyscreen.trainerParty = trainer;
                    this.Visibility = Visibility.Hidden;
                    partyscreen.ShowDialog();
                    this.Visibility = Visibility.Visible;
                    break;
                case 2:
                    this.Visibility = Visibility.Hidden;
                    //MAAK HIER DE CODE VOOR DE INVENTORY  TE ROEPEN MET SHOW DIALOG, EN PASS DE TRAINER VARIABLE ER NAAR TOE



                    this.Visibility = Visibility.Visible;
                    break;
                case 3:
                    this.Visibility = Visibility.Hidden;
                    //MAAK HIER DE CODE VOOR DE TRAINER CARRD AAN TE ROEPEN MET SHOW DIALOG, EN PASS DE TRAINER VARIABLE ER NAAR TOE

                    this.Visibility = Visibility.Visible;
                    break;
                default: Close();

                    break;
            }
        }
    }
}
