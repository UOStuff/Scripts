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
	public class CyborgSpaceScreen1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CyborgSpaceScreen1AddonDeed();
			}
		}

		[ Constructable ]
		public CyborgSpaceScreen1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3146 );
			AddComponent( ac, -1, 0, 18 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -3, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -1, -1, 16 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -3, -1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -1, -1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -2, -1, 5 );
			ac = new AddonComponent( 3150 );
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 8159 );
			ac.Light = LightType.Circle225;
			ac.Hue = 2903;
			AddComponent( ac, 0, 0, 22 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -2, -1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -2, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 3142 );
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -3, -1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -1, -1, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 5 );
			ac = new AddonComponent( 3142 );
			AddComponent( ac, -2, 0, 23 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 10 );
			ac = new AddonComponent( 14277 );
			ac.Hue = 1266;
			AddComponent( ac, -2, 0, 8 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -3, -1, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -1, -1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, -2, -1, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 20 );
			ac = new AddonComponent( 14273 );
			ac.Hue = 2902;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3142 );
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 3147 );
			AddComponent( ac, -1, 0, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 2, -1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 14272 );
			ac.Hue = 2901;
			AddComponent( ac, 4, 1, 16 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 4, -1, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 4, -1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 2, -1, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 3146 );
			AddComponent( ac, 3, 0, 18 );
			ac = new AddonComponent( 14276 );
			ac.Hue = 1;
			AddComponent( ac, 2, 0, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 4, -1, 10 );
			ac = new AddonComponent( 14277 );
			ac.Hue = 2923;
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 4, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 3, -1, 5 );
			ac = new AddonComponent( 3147 );
			AddComponent( ac, 3, 0, 18 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 2, -1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 3, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 3, -1, 20 );
			ac = new AddonComponent( 14278 );
			ac.Hue = 2582;
			AddComponent( ac, 2, 0, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 2, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 3, -1, 10 );
			ac = new AddonComponent( 3142 );
			AddComponent( ac, 3, 0, 10 );

		}

		public CyborgSpaceScreen1Addon( Serial serial ) : base( serial )
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

	public class CyborgSpaceScreen1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CyborgSpaceScreen1Addon();
			}
		}

		[Constructable]
		public CyborgSpaceScreen1AddonDeed()
		{
			Name = "CyborgSpaceScreen1";
		}

		public CyborgSpaceScreen1AddonDeed( Serial serial ) : base( serial )
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