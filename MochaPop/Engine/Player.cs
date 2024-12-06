using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Animations;
using MonoGame.Extended.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Content
{
    internal class Player
    {

        private Game1 Game;

        public Rectangle _rectangle = new Rectangle(0,0,512,512);
        private SpriteSheet _sprite;
        private AnimationController _notpop;
        private AnimationController _pop;
        private AnimationController _sad;
        public void LoadContent(Game1 game)
        {
            Game = game;
            Texture2D playerTexture = Game.Content.Load<Texture2D>("Characters/Sprites/Normal");
            Texture2DAtlas atlas = Texture2DAtlas.Create("Atlas/player", playerTexture, 1600, 1600);
            _sprite = new SpriteSheet("SpriteSheet/player", atlas);

            _sprite.DefineAnimation("notpop", builder =>
            {
                builder.IsLooping(true)
                .AddFrame(0, TimeSpan.FromSeconds(0.2))
                .AddFrame(3, TimeSpan.FromSeconds(0.2));
            });
            _sprite.DefineAnimation("pop", builder =>
            {
                builder.IsLooping(true)
                .AddFrame(1, TimeSpan.FromSeconds(0.2))
                .AddFrame(4, TimeSpan.FromSeconds(0.2));
            });
            _sprite.DefineAnimation("sad", builder =>
            {
                builder.IsLooping(true)
                .AddFrame(2, TimeSpan.FromSeconds(0.2))
                .AddFrame(5, TimeSpan.FromSeconds(0.2));
            });
            SpriteSheetAnimation notPop = _sprite.GetAnimation("notpop");
            SpriteSheetAnimation pop = _sprite.GetAnimation("pop");
            SpriteSheetAnimation sad = _sprite.GetAnimation("sad");
            _notpop = new AnimationController(notPop);
            _pop = new AnimationController(pop);
            _sad = new AnimationController(sad);
        }

        public void Update(GameTime gameTime)
        {
                _notpop.Update(gameTime);
                _pop.Update(gameTime);
        }

        public void Draw()
        {
            Texture2DRegion currentFrameTexture = Game.isPopping ? _sprite.TextureAtlas[_pop.CurrentFrame] : _sprite.TextureAtlas[_notpop.CurrentFrame];
            Game._spriteBatch.Draw(currentFrameTexture, new Rectangle(0, 0, 512, 512), Color.White);
        }
    }
}
