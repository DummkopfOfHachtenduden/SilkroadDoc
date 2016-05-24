public enum ResourceType : uint
{
	/// <summary>
	/// Characters of all races (EU, CH)
	/// </summary>
	Character = 0x20000,

	/// <summary>
	/// NPCs, Monsters, COS
	/// </summary>
	NPC = 0x20001,

	/// <summary>
	/// Walls, Houses, Fences
	/// </summary>
	Building = 0x20002,

	/// <summary>
	/// Static Map-Objects that are not buildings (carriage, bones, etc.)
	/// </summary>
	Artifact = 0x20003,

	/// <summary>
	/// Trees, Plants, Flowers, Bushes
	/// </summary>
	Nature = 0x20004,

	/// <summary>
	/// All Items-Props
	/// </summary>
	Item = 0x20005,

	/// <summary>
	/// Drops, Marks
	/// </summary>
	Other = 0x20006,

	/// <summary>
	/// Compound of character and items he is wearing.
	/// </summary>
	CompoundCharacter = 0x30000,

	/// <summary>
	/// Compound of multiple buildings, artifacts or nature objects.
	/// </summary>
	CompoundObject = 0x30002,
}