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
	public class DarkElfFenceEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DarkElfFenceEastAddonDeed();
			}
		}

		[ Constructable ]
		public DarkElfFenceEastAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, -4, 0 );
			ac = new AddonComponent( 8708 );
			AddComponent( ac, 1, 4, 10 );
			ac = new AddonComponent( 8707 );
			AddComponent( ac, 1, 4, 30 );
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 8708 );
			AddComponent( ac, 1, 1, 9 );
			ac = new AddonComponent( 8707 );
			AddComponent( ac, 1, 1, 29 );
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 545 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 8708 );
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 8707 );
			AddComponent( ac, 1, -2, 27 );

		}

		public DarkElfFenceEastAddon( Serial serial ) : base( serial )
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

	public class DarkElfFenceEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DarkElfFenceEastAddon();
			}
		}

		[Constructable]
		public DarkElfFenceEastAddonDeed()
		{
			Name = "DarkElfFenceEast";
		}

		public DarkElfFenceEastAddonDeed( Serial serial ) : base( serial )
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