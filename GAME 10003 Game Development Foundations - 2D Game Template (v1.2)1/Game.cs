// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Texture2D texture;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Load Asset Example");
            Window.SetSize(400, 400);

            string cwd = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(cwd);

            string filePath = "../../../../assets/images/character.png";
            texture = Graphics.LoadTexture(filePath);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            Graphics.Draw(texture, 10, 10);
        }
    }
}
