using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using MonoGame.Extended.Screens;
using MonoGame.Extended.ViewportAdapters;
using System.Collections.Generic;

namespace Engine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private readonly ScreenManager _screenManager;
        public ViewportAdapter viewportAdapter;
#if ANDROID
        public readonly Point ScreenSize = new(2280, 1080);
#else
        public readonly Point ScreenSize = new(1920, 1080);
#endif

        public float DeltaTime;

        public int PopCount = 0;
        public bool isPopping = false;
        public bool wasPopping = false;
        public bool popOpen = false;
        public bool popClose = false;
        public Color backgroundColor = new Color(0, 124, 124);
        public Dictionary<string, Color> Colors;
        public enum Screens { Pop, Shop }

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _screenManager = new ScreenManager();
            Components.Add(_screenManager);
#if ANDROID
            _graphics.IsFullScreen = true;
#else
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
#endif
            Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            Colors = new Dictionary<string, Color>();
            Colors.Add("Default", new Color(0, 124, 124));
            LoadScreen((int)Screens.Pop);
        }

        protected override void LoadContent()
        {
#if ANDROID
            viewportAdapter = new BoxingViewportAdapter(Window, GraphicsDevice, 2280, 1080);
#else
            viewportAdapter = new BoxingViewportAdapter(Window, GraphicsDevice, 1920, 1080);
#endif
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            DeltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backgroundColor * 0.5f);

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

            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();
            isPopping = false;
            if (keyboard.IsKeyDown(Keys.Space)) 
                isPopping = true;
            TouchCollection touchPanelState = TouchPanel.GetState();
            if (touchPanelState.Count > 0) isPopping = true;

            popOpen = (isPopping && !wasPopping) ? true : false;
            popClose = (!isPopping && wasPopping) ? true : false;
        }
    }
}
