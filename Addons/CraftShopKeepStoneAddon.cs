/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CraftShopKeepStoneAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CraftShopKeepStoneAddonDeed();
			}
		}

		[ Constructable ]
		public CraftShopKeepStoneAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -1, -4, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -2, -4, 0 );
			ac = new AddonComponent( 10662 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 466 );
			AddComponent( ac, -3, -4, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, -2, 20 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, -3, 20 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 2877 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, -2, 23 );
			ac = new AddonComponent( 2877 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, -3, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, 1, 17 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, 0, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, -3, 23 );
			ac = new AddonComponent( 2879 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, 1, 20 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 4021 );
			AddComponent( ac, 0, -3, 6 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, 2, 20 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, 0, 20 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, -1, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, 2, 17 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, -1, 23 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, -2, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, 0, 23 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, -1, 20 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, 2, 23 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, 1, 23 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 6020 );
			AddComponent( ac, 0, 5, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, 4, 20 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, 4, 17 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, 4, 23 );
			ac = new AddonComponent( 10662 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, 3, 23 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 6020 );
			AddComponent( ac, -1, 5, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 6020 );
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, 3, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -2, 5, 17 );
			ac = new AddonComponent( 3233 );
			AddComponent( ac, -2, 5, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, 0, 5, 23 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, 3, 20 );
			ac = new AddonComponent( 6459 );
			AddComponent( ac, -1, 5, 20 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 1, -4, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, -2, 23 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, 2, 23 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 7155 );
			AddComponent( ac, 1, -3, 6 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, 0, 23 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, -3, 23 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, 1, 23 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, -1, 23 );
			ac = new AddonComponent( 2879 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 3208 );
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 6790 );
			AddComponent( ac, 4, -4, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 2, -4, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, 2, 20 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, 1, 20 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, 0, 20 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, -1, 20 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 6023 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, -2, 20 );
			ac = new AddonComponent( 6021 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 6786 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, -3, 20 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, -1, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 4022 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, -2, 17 );
			ac = new AddonComponent( 6021 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, 2, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 6024 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 465 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 6019 );
			AddComponent( ac, 4, 2, 0 );
			ac = new AddonComponent( 6019 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 6019 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 6019 );
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, 2, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, 1, 17 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, 0, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 6787 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 6021 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 6019 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, -3, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, 5, 23 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 464 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 6020 );
			AddComponent( ac, 1, 5, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, 3, 23 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 1, 4, 23 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 6019 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, 5, 20 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, 4, 20 );
			ac = new AddonComponent( 4982 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 6022 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 3204 );
			AddComponent( ac, 2, 5, 0 );
			ac = new AddonComponent( 6025 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 6020 );
			AddComponent( ac, 2, 5, 0 );
			ac = new AddonComponent( 4983 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, 4, 17 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, 3, 17 );
			ac = new AddonComponent( 10666 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 3, 5, 17 );
			ac = new AddonComponent( 6457 );
			AddComponent( ac, 2, 3, 20 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 463 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 6021 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 1180 );
			AddComponent( ac, 3, 4, 0 );

		}

		public CraftShopKeepStoneAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CraftShopKeepStoneAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CraftShopKeepStoneAddon();
			}
		}

		[Constructable]
		public CraftShopKeepStoneAddonDeed()
		{
			Name = "CraftShopKeepStone";
		}

		public CraftShopKeepStoneAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}