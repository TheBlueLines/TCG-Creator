using System.Text.Json.Serialization;

namespace TCG_Creator
{
	public class Resource
	{
		public Pack? pack { get; set; }
	}
	public class Pack
	{
		public byte pack_format { get; set; }
		public string? description { get; set; }
	}
	public class Model
	{
		public string? parent { get; set; }
		public Texture? textures { get; set; }
		public Display? display { get; set; }
		public List<Override>? overrides { get; set; }
	}
	public class Display
	{
		[JsonPropertyName("fixed")]
		public Edit? Fixed { get; set; }
		public Edit? thirdperson_righthand { get; set; }
		public Edit? thirdperson_lefthand { get; set; }
		public Edit? firstperson_righthand { get; set; }
		public Edit? firstperson_lefthand { get; set; }
		public Edit? ground { get; set; }
	}
	public class Edit
	{
		public List<float>? translation { get; set; }
		public List<float>? scale { get; set; }
	}
	public class Texture
	{
		public string? layer0 { get; set; }
	}
	public class Override
	{
		public Predicate? predicate { get; set; }
		public string? model { get; set; }
	}
	public class Predicate
	{
		public int custom_model_data { get; set; }
	}
}