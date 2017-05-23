using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;    
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //add all rectangles, Texture2D, and variables here

        Texture2D droneSprite;
        Vector2 dronePosition;
        Vector2 droneYSpeed;
        Vector2 gravity;
        Vector2 droneXSpeed;




        SpriteFont font1;

        enum GameState
        {
            MainMenu,
            PlayGame,
            EndGame
        }
        GameState state = GameState.MainMenu;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = true;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            dronePosition = new Vector2(375, 5);
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            droneSprite = Content.Load<Texture2D>("drone");


            //fonts
            font1 = Content.Load<SpriteFont>("font1");
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            Rectangle DroneCollision1 = new Rectangle((int)dronePosition.X, (int)dronePosition.Y, droneSprite.Width, droneSprite.Height);
            Rectangle DroneCollision2 = new Rectangle((int)dronePosition.X + droneSprite.Width/2, (int)dronePosition.Y +5, droneSprite.Width-10, droneSprite.Height- 30);
            dronePosition.Y += gravity.Y;

            
            // TODO: Add your update logic here
            // GameState.MainMenu;

            // TODO: Add your update logic here
            
            switch(state)
            {
                case GameState.MainMenu:
                    break;
                case GameState.PlayGame:
                    break;
                case GameState.EndGame:
                    break;
            }

            base.Update(gameTime);
        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.LemonChiffon);

            // TODO: Add your drawing code here

            switch (state)
            {
                case GameState.MainMenu:
                    DisplayMainMenu();
                    break;

                case GameState.PlayGame:
                    DisplayPlayGame();
                    break;

                case GameState.EndGame:
                    DisplayMainMenu();
                    break;
            }


            spriteBatch.Draw(droneSprite, dronePosition, Color.White);



            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void DisplayMainMenu()
        {
            spriteBatch.DrawString(font1, "Drone Simulator 2017", new Vector2(100, 50), Color.Black);

        }

        public void DisplayEndGame()
        {

        }

        public void DisplayPlayGame()
        {
            spriteBatch.Draw(droneSprite, new Vector2(25, 25), Color.White);

        }
    }
}
