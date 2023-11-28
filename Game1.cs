using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_Intro_take_3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D ccmbrTexture;
        Texture2D crtTexture;
        Texture2D cntrTexture;
        Texture2D ltcTexture;
        Texture2D onnTexture;
        Texture2D tmtTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Nefarious Veggies";
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ccmbrTexture = Content.Load<Texture2D>("cucumber");
            crtTexture = Content.Load<Texture2D>("download");
            cntrTexture = Content.Load<Texture2D>("countertop");
            ltcTexture = Content.Load<Texture2D>("lettuce");
            onnTexture = Content.Load<Texture2D>("onion");
            tmtTexture = Content.Load<Texture2D>("tomato");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(cntrTexture, new Vector2(-120, -120), Color.White);
            _spriteBatch.Draw(ltcTexture, new Vector2(50, 240), Color.White);
            _spriteBatch.Draw(onnTexture, new Vector2(90, 300), Color.White);
            _spriteBatch.Draw(tmtTexture, new Vector2(130, 275), Color.White);
            _spriteBatch.Draw(crtTexture, new Vector2(150, 285), Color.White);
            _spriteBatch.Draw(ccmbrTexture, new Vector2(40, 275), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}