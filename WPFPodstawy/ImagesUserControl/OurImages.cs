using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesUserControl
{
    public class OurImage
    {

        public string PropOfImage
        {
            get
            {
                return "Default";
            }
        }

        //private string _asd; //prywatna zmienna zawiera w nazwie "_"

        public string PathOfImage { get; set; } // properties zawsze zaczynamy z dużych liter 
        public string NameOfImage { get; set; }
        public bool IsFound { get; set; } // tworzymy zmienną, którą wykorzystamy do stworzenia metody czy obrazek istnieje 
        
        



        public OurImage() //nazwy metod zaczynamy z dużych
        {
            this.PathOfImage = "defualt.png";
            this.NameOfImage = "Default";
            
            
        }
        
        public OurImage(string pathOfImage, string nameOfImage) //camelcase mała a potem duże 
        {
            this.PathOfImage = pathOfImage;
            this.NameOfImage = nameOfImage;
            //tutaj sprawdzamy czy istnieje plik
            this.IsFound = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), pathOfImage));

            
           

        }
    
       
        
    }

   
}
