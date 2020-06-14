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
	public class KitchenCabinetsAAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new KitchenCabinetsAAddonDeed();
			}
		}

		[ Constructable ]
		public KitchenCabinetsAAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 0, -2, 1 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 1856;
			AddComponent( ac, 0, -2, 12 );
			ac = new AddonComponent( 11526 );
			ac.Hue = 1856;
			AddComponent( ac, 0, -3, 1 );
			ac = new AddonComponent( 2451 );
			AddComponent( ac, 0, -2, 6 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 1856;
			AddComponent( ac, 0, 2, 12 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 1856;
			AddComponent( ac, 0, -1, 12 );
			ac = new AddonComponent( 11754 );
			ac.Hue = 1856;
			AddComponent( ac, 0, 1, 14 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 0, 3, 1 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 0, 2, 1 );
			ac = new AddonComponent( 10332 );
			ac.Hue = 1856;
			AddComponent( ac, 0, 3, 12 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, 2, 7 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 1801 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 11526 );
			ac.Hue = 1856;
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 6867 );
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 2519 );
			AddComponent( ac, 0, 0, 5 );

		}

		public KitchenCabinetsAAddon( Serial serial ) : base( serial )
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

	public class KitchenCabinetsAAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new KitchenCabinetsAAddon();
			}
		}

		[Constructable]
		public KitchenCabinetsAAddonDeed()
		{
			Name = "KitchenCabinetsA";
		}

		public KitchenCabinetsAAddonDeed( Serial serial ) : base( serial )
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