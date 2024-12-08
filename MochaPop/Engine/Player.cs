using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Animations;
using MonoGame.Extended.Graphics;
using System;

namespace Engine.Content
{
    internal class Player
    {

        private Game1 Game;

        Random random = new Random();
        public Rectangle _rectangle = new Rectangle(0,0,1080,1080);
        private SpriteSheet _sprite;
        private SoundEffect _popSound;
        private SoundEffect _unpopSound;
        private SoundEffect _a;
        private SoundEffect _i;
        private SoundEffect _u;
        private SoundEffect _e;
        private SoundEffect _o;
        private AnimationController _notpop;
        private AnimationController _pop;
        private AnimationController _sad;
        public void LoadContent(Game1 game)
        {
            Game = game;
            #region Visuals
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
            #endregion

            #region Sound
            _popSound = Game.Content.Load<SoundEffect>("Characters/Sounds/pop");
            _unpopSound = Game.Content.Load<SoundEffect>("Characters/Sounds/unpop");
            _a = Game.Content.Load<SoundEffect>("Characters/Sounds/mm_a");
            _i = Game.Content.Load<SoundEffect>("Characters/Sounds/mm_i");
            _u = Game.Content.Load<SoundEffect>("Characters/Sounds/mm_u");
            _e = Game.Content.Load<SoundEffect>("Characters/Sounds/mm_e");
            _o = Game.Content.Load<SoundEffect>("Characters/Sounds/mm_o");
            #endregion

        }

        public void Update(GameTime gameTime)
        {
                Game.CheckPop();
                _notpop.Update(gameTime);
                _pop.Update(gameTime);

            if (Game.popOpen)
            {
                float pitch =  random.Next(-5, 5) * 0.01f;
                _popSound.Play(1,pitch,0);
                Game.PopCount++;
            }

            if (Game.popClose)
            {
                float pitch = random.Next(-5, 5) * 0.01f;
                _unpopSound.Play(1, pitch, 0);
            }
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            Texture2DRegion currentFrameTexture = Game.isPopping ? _sprite.TextureAtlas[_pop.CurrentFrame] : _sprite.TextureAtlas[_notpop.CurrentFrame];
            _spriteBatch.Draw(currentFrameTexture, _rectangle, Color.White);
        }
    }
}
