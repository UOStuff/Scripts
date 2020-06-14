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
	public class Hall2011PumpkinBigBagAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2011PumpkinBigBagAddonDeed();
			}
		}

		[ Constructable ]
		public Hall2011PumpkinBigBagAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2485 );
			ac.Hue = 1161;
			AddComponent( ac, 1, 1, 10 );
			ac = new AddonComponent( 5929 );
			ac.Hue = 1161;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 5444 );
			ac.Hue = 73;
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 8791 );
			ac.Hue = 43;
			AddComponent( ac, 0, 0, 0 );

		}

		public Hall2011PumpkinBigBagAddon( Serial serial ) : base( serial )
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

	public class Hall2011PumpkinBigBagAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2011PumpkinBigBagAddon();
			}
		}

		[Constructable]
		public Hall2011PumpkinBigBagAddonDeed()
		{
			Name = "Hall2011PumpkinBigBag";
		}

		public Hall2011PumpkinBigBagAddonDeed( Serial serial ) : base( serial )
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