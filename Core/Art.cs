using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TTT
{
    static class Art
	{
		public static Texture2D X { get; private set; }
		public static Texture2D O { get; private set; }
		public static Texture2D E { get; private set; }
		public static Texture2D Select { get; private set;}

		public static void Load(ContentManager content)
		{
            X = content.Load<Texture2D>("x");
            O = content.Load<Texture2D>("o");
            E = content.Load<Texture2D>("e");
		}
	}
}