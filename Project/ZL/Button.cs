namespace ZL
{
    public sealed class Button : UI
    {
        private readonly Dictionary<State, Sprite> sprites;
        private readonly Dictionary<State, Text> texts;

        public Button(Coord position, Navigation navigation, Dictionary<State, Sprite> sprites, Dictionary<State, Text> texts) :
            
            base(position, navigation)
        {
            this.sprites = sprites;
            this.texts = texts;
        }

        public override void Draw()
        {
            sprites[state].Draw(position);
            texts[state].Draw(position);
        }
    }
}