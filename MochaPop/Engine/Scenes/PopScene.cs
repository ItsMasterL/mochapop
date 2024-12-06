using Engine.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Animations;
using MonoGame.Extended.Content;
using MonoGame.Extended.Graphics;
using MonoGame.Extended.Screens;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Engine
{
    internal class PopScene : GameScreen
    {
        private new Game1 Game => (Game1) base.Game;
        private SpriteFont _font;
        public PopScene(Game1 game) : base(game) { }

        private Player _player;

        public override void LoadContent()
        {
            base.LoadContent();
            _font = Content.Load<SpriteFont>("default");
            _player = new Player();
            _player.LoadContent(Game);
        }

        public override void Update(GameTime gameTime)
        {
            Game.CheckPop();
            _player.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Game.GraphicsDevice.Clear(new Color(0, 124, 124));
            Game._spriteBatch.Begin();
            Game._spriteBatch.DrawString(_font, "Click, Press Space, or Tap to Pop", new Vector2(10, 10), Color.White);
            _player.Draw();
            Game._spriteBatch.End();
        }
    }
}
