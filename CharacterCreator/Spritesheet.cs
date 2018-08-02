using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CharacterCreator
{
    class Spritesheet
    {
        private Image image = null;

        public string path;
        public int GetWidth()
        {
            // add implementation here
            if (image != null)
            {
                return image.Width;
            }
            return 0;
        }

        public int GetHeight()
        {
            // add implementation here
            if (image != null)
            {
                return image.Height;
            }
            return 0;
        }

        public Spritesheet(string path)
        {
            this.path = path;
            Load();
        }

        public void Load()
        {
            image = Image.FromFile(@"J:\GITREPO\MathLibraryCLR\roguelikeChar_transparent.png");
        }

        public override string ToString()
        {
            return base.ToString() + ": " + path.ToString();
        }

    }
}
