using Engine.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.Animations;
using MonoGame.Extended.Content;
using MonoGame.Extended.Graphics;
using MonoGame.Extended.Screens;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Engine
{
    internal class PopScene : GameScreen
    {
        private new Game1 Game => (Game1) base.Game;
        private SpriteBatch _spriteBatch;
        private SpriteFont _font;
        public PopScene(Game1 game) : base(game) { }

        private Player _player;

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent()
        {
            base.LoadContent();
            _spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            _font = Content.Load<SpriteFont>("default");
            _player = new Player();
            _player.LoadContent(Game);
        }

        public override void Update(GameTime gameTime)
        {
            _player.Update(gameTime);
            Game.backgroundColor = ColorModifiers.Rainbow(Game.backgroundColor, gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            //Game.GraphicsDevice.Clear(new Color(0, 124, 124));
            
            _spriteBatch.Begin(transformMatrix: Game.viewportAdapter.GetScaleMatrix());
            _spriteBatch.DrawRectangle(new RectangleF(0, 0, Game.ScreenSize.X, Game.ScreenSize.Y), Game.backgroundColor, Game.ScreenSize.Y);
            _player.Draw(_spriteBatch);
#if ANDROID
            _spriteBatch.DrawString(_font, "Tap to Pop!", new Vector2(50, 50), Color.White);
#else
            _spriteBatch.DrawString(_font, "Press Space to Pop!", new Vector2(50, 50), Color.White);
#endif
            _spriteBatch.DrawString(_font, Game.PopCount.ToString(), new Vector2(Game.ScreenSize.X - 480, 500), Color.White);
            _spriteBatch.End();
        }
    }
}
