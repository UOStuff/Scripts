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
	public class D14EasterBunnyIndigoAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new D14EasterBunnyIndigoAddonDeed();
			}
		}

		[ Constructable ]
		public D14EasterBunnyIndigoAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 10139 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3576 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 3576 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 10118 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 3576 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 10136 );
			ac.Hue = 2712;
			AddComponent( ac, 0, 0, 9 );
			ac = new AddonComponent( 8965 );
			ac.Hue = 2712;
			AddComponent( ac, 1, 0, 9 );
			ac = new AddonComponent( 3576 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 3864 );
			ac.Hue = 2712;
			AddComponent( ac, 0, 0, 11 );
			ac = new AddonComponent( 5441 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 5441 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 1, 15 );
			ac = new AddonComponent( 6479 );
			ac.Hue = 2666;
			AddComponent( ac, 0, 1, 2 );

		}

		public D14EasterBunnyIndigoAddon( Serial serial ) : base( serial )
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

	public class D14EasterBunnyIndigoAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new D14EasterBunnyIndigoAddon();
			}
		}

		[Constructable]
		public D14EasterBunnyIndigoAddonDeed()
		{
			Name = "D14EasterBunnyIndigo";
		}

		public D14EasterBunnyIndigoAddonDeed( Serial serial ) : base( serial )
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