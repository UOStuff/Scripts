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
	public class EasterBunnysShackAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EasterBunnysShackAddonDeed();
			}
		}

		[ Constructable ]
		public EasterBunnysShackAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 12584 );
			ac.Hue = 1153;
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 12585 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 0, 3 );
			ac = new AddonComponent( 2485 );
			ac.Hue = 1161;
			AddComponent( ac, -1, 0, 5 );
			ac = new AddonComponent( 2485 );
			ac.Hue = 1161;
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 8900 );
			AddComponent( ac, 0, -1, 3 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 13001 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3190 );
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 3190 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 3190 );
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 7025 );
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 4090 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 3127 );
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 3252 );
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 3253 );
			AddComponent( ac, 1, -1, 2 );
			ac = new AddonComponent( 3258 );
			AddComponent( ac, 1, -1, 2 );

		}

		public EasterBunnysShackAddon( Serial serial ) : base( serial )
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

	public class EasterBunnysShackAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EasterBunnysShackAddon();
			}
		}

		[Constructable]
		public EasterBunnysShackAddonDeed()
		{
			Name = "EasterBunnysShack";
		}

		public EasterBunnysShackAddonDeed( Serial serial ) : base( serial )
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