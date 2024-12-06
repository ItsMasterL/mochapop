using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
using System;

namespace Engine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;

        private readonly ScreenManager _screenManager;

        public int PopCount = 0;
        public bool isPopping = false;
        public bool wasPopping = false;
        public bool popOpen = false;
        public bool popClose = false;
        public enum Screens { Pop, Shop }

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _screenManager = new ScreenManager();
            Components.Add(_screenManager);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            LoadScreen((int)Screens.Pop);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
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
            
            base.Draw(gameTime);
        }

        private void LoadScreen(int ScreenID)
        {
            switch (ScreenID)
            {
                default:
                case 0:
                    _screenManager.LoadScreen(new PopScene(this));
                    break;
            }
        }

        public void CheckPop()
        {
            wasPopping = isPopping;

            KeyboardState keyboard = new KeyboardState();
            MouseState mouse = new MouseState();
            isPopping = false;
            if (keyboard.IsKeyDown(Keys.Space) || mouse.LeftButton == ButtonState.Pressed) 
                isPopping = true;
            TouchCollection touchPanelState = TouchPanel.GetState();
            if (touchPanelState.Count > 0) isPopping = true;

            popOpen = (isPopping && !wasPopping) ? true : false;
            popClose = (!isPopping && wasPopping) ? true : false;
        }
    }
}
