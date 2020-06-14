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
	public class DeskEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DeskEAddonDeed();
			}
		}

		[ Constructable ]
		public DeskEAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 11763 );
			ac.Hue = 1508;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, 0, 15 );
			ac = new AddonComponent( 11763 );
			ac.Hue = 1508;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2879 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 4555 );
			AddComponent( ac, -1, 0, 17 );
			ac = new AddonComponent( 2913 );
			ac.Hue = 1508;
			AddComponent( ac, -1, 1, 13 );
			ac = new AddonComponent( 2913 );
			ac.Hue = 1508;
			AddComponent( ac, -1, 1, 17 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, -1, 15 );
			ac = new AddonComponent( 7713 );
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 2785 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2879 );
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, 1, 10 );
			ac = new AddonComponent( 5356 );
			AddComponent( ac, -1, -1, 7 );
			ac = new AddonComponent( 2913 );
			ac.Hue = 1508;
			AddComponent( ac, -1, -1, 9 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, 0, 10 );
			ac = new AddonComponent( 7715 );
			AddComponent( ac, -1, 1, 14 );
			ac = new AddonComponent( 3710 );
			ac.Hue = 1508;
			AddComponent( ac, -1, -1, 17 );
			ac = new AddonComponent( 2877 );
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, 1, 15 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2913 );
			ac.Hue = 1508;
			AddComponent( ac, -1, 0, 12 );
			ac = new AddonComponent( 2780 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2783 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, -1, 10 );
			ac = new AddonComponent( 2778 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2785 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2784 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2913 );
			ac.Hue = 1508;
			AddComponent( ac, -1, -1, 16 );
			ac = new AddonComponent( 2897 );
			ac.Hue = 1508;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 8006 );
			AddComponent( ac, -1, 1, 8 );
			ac = new AddonComponent( 2782 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 7716 );
			AddComponent( ac, -1, -1, 12 );
			ac = new AddonComponent( 4084 );
			AddComponent( ac, -1, 0, 8 );
			ac = new AddonComponent( 2785 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4031 );
			AddComponent( ac, -1, 1, 7 );
			ac = new AddonComponent( 2783 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2783 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, 2, 9 );
			ac = new AddonComponent( 2781 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 4174 );
			AddComponent( ac, -1, 2, 15 );
			ac = new AddonComponent( 2786 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2779 );
			AddComponent( ac, 1, 2, 0 );

		}

		public DeskEAddon( Serial serial ) : base( serial )
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

	public class DeskEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DeskEAddon();
			}
		}

		[Constructable]
		public DeskEAddonDeed()
		{
			Name = "DeskE";
		}

		public DeskEAddonDeed( Serial serial ) : base( serial )
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