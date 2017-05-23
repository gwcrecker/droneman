﻿using Microsoft.Xna.Framework;
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
        Vector2 droneSpeed;
        

        SpriteFont font1;

       

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
            dronePosition = new Vector2(100, 199);
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


            // TODO: Add your update logic here
            // GameState.MainMenu;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.LemonChiffon );

            // TODO: Add your drawing code here
            



            spriteBatch.Draw(droneSprite,dronePosition, Color.White);

           

            spriteBatch.End();
            base.Draw(gameTime);
        }

      
    }
}
