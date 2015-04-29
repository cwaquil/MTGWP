using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;

namespace MTGWindowsPhone.Entidades
{
    public partial class Dado : PhoneApplicationPage
    {

        public Dado()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan interval = TimeSpan.FromMilliseconds(2400);

            Storyboard_Dice.Begin();

            for (int i = 0; i < myDoubleAnimationUsingKeyFrames_X.KeyFrames.Count; i++)
            {
                RandonlyDice();
                for (int y = 0; y < myDoubleAnimationUsingKeyFrames_Y.KeyFrames.Count; y++)
                {
                    Storyboard_Dice.Pause();
                    RandonlyDice();
                    Storyboard_Dice.Resume();
                }
                Storyboard_Dice.Begin();


            //    Storyboard_Dice_1.Pause();
            //    //RandonDice();
            //    RandonlyDice();
            //    Storyboard_Dice_1.Resume();

                //DoubleKeyFrame kFrameY = myDoubleAnimationUsingKeyFrames_Y.KeyFrames[i];
                //DoubleKeyFrame kFrameX = myDoubleAnimationUsingKeyFrames_X.KeyFrames[i];
                //if (kFrameY.GetType().Name == "EasingDoubleKeyFrame" || kFrameX.GetType().Name == "EasingDoubleKeyFrame")
                //{
                //    //Storyboard_Dice_1.Pause();
                //    RandonDice();
                //    //Storyboard_Dice_1.Resume();
                //} 
            }

           

            //for (int r = 0; r <= 3; r++)
            //{
            //    //Storyboard_Dice_1.Pause();
            //    System.Threading.Thread.Sleep(200);
                
            //    Storyboard_Dice_1.Seek(TimeSpan.FromMilliseconds(100));
            //    //Storyboard_Dice_1.Resume();
            //}
            //for (int roll = 1; roll <= 20; roll++)
            //{
            //    Img = new BitmapImage(new Uri(@"/Assets/Dado/dice" + roll.ToString() + ".png", UriKind.Relative));
            //    dice1.Source = Img;
            //    //System.Threading.Thread.Sleep(100);
            //}
        }

        private void RandonDice()
        {
            Random rand = new Random();
            int randNumber = rand.Next(1, 20);
            BitmapImage Img = new BitmapImage(new Uri(@"/Assets/Dado/dice" + randNumber.ToString() + ".png", UriKind.Relative));
            dice1.Source = Img;
        }

        private void RandonlyDice()
        {
            Random rand = new Random();
            int randNumber = rand.Next(1, 20);
            string fileImage = "/Assets/Dado/dice" + randNumber.ToString() + ".png";
            BitmapImage image = new BitmapImage();
            image.UriSource = new Uri(@fileImage, UriKind.RelativeOrAbsolute);
            dice1.Source = image;
        }

    }
}