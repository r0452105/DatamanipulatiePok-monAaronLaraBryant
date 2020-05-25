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
using System.Windows.Shapes;
using PokemonDAL;
using PokemonModels;
using PokemonWPF;

namespace PokemonWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PokédexWindow : Window
    {
        public MainWindow WindowToAlter;
        public Pokedex pokedex = new Pokedex();
        IList<Pokedex> pokeEntries = DatabaseOperations.PokedexEntry();
        public Types poketype = new Types();
        List<Types> poketypeentries = DatabaseOperations.Typinglist();
        Bulbasaur pokedexPic1 = new Bulbasaur();
        List<PokemonGroup> pokeparty = DatabaseOperations.SelectParty(2);

        public PokédexWindow()
        {
            InitializeComponent();
            
            //if searchscherm is zonet gebruikt dan komt er mogelijks een alternatief else zie hieronder
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            

            int partycount =pokeparty.Count;
            lvPokedex.ItemsSource = pokeEntries;
            lblSeenCaptured.Content = "\nSeen: " + pokeEntries.Count + " \nOwned: "+partycount;// owned nog automatiseren

            BitmapImage bulbasaur = new BitmapImage(new Uri("Images/PokemonSprites.png", UriKind.Relative));
            lvPokedex.SelectedIndex = 0;
            //imgPicturePokémon.Source = new CroppedBitmap(bulbasaur, pokedexPic1.target);
        }



        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e) //search nog compleet uitwerken
        {
            SearchDexWindow searchDexWindow1 = new SearchDexWindow();
            this.Visibility = Visibility.Hidden;
            searchDexWindow1.DexWindowToAlter = this;
            searchDexWindow1.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void BtnCRUD_Click(object sender, RoutedEventArgs e)
        {
            PokedexCRUDWindow CRUDWindow1 = new PokedexCRUDWindow();
            this.Visibility = Visibility.Hidden;
            CRUDWindow1.DexWindowToAlter = this;
            CRUDWindow1.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void LvPokedex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            foreach (Pokedex pokedex1 in pokeEntries)
            {
                if (lvPokedex.SelectedIndex==(pokedex1.Id-1)){
                    BitmapImage sprite = new BitmapImage(new Uri("Images/PokemonSprites.png", UriKind.Relative));
                    PokemonSpriteById spriteTarget = new PokemonSpriteById(pokedex1.Id);
                    imgPicturePokémon.Source = new CroppedBitmap(sprite, spriteTarget.target);
                }
            }
            
            
        }

        private void LvPokedex_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PokémonInfoWindow PokéInfoWindow1 = new PokémonInfoWindow();
            this.Visibility = Visibility.Hidden;
            PokéInfoWindow1.DexWindowToAlter = this;
            PokéInfoWindow1.ShowDialog();
            //problem opening main
            this.Visibility = Visibility.Visible;
        }
    }
}
