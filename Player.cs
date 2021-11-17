using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Player : GameObject {


	public Player(Game game, string pathToTexture, Vector2 position) : base(game, pathToTexture, position)
	{}

	public void Draw(SpriteBatch spriteBatch) {
		spriteBatch.Draw(
			this.texture,
			this.position,
			null,
			Color.White,
			0f,
			Vector2.Zero,
			Vector2.One,
			SpriteEffects.None,
			0f
		);
	}
}