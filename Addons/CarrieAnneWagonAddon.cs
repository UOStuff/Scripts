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
	public class CarrieAnneWagonAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CarrieAnneWagonAddonDeed();
			}
		}

		[ Constructable ]
		public CarrieAnneWagonAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3367 );
			ac.Hue = 1341;
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 3367 );
			AddComponent( ac, 0, -2, 7 );
			ac = new AddonComponent( 3231 );
			ac.Hue = 1645;
			AddComponent( ac, 1, -3, 7 );
			ac = new AddonComponent( 3203 );
			ac.Hue = 1645;
			AddComponent( ac, 0, -1, 10 );
			ac = new AddonComponent( 3231 );
			AddComponent( ac, 0, -3, 8 );
			ac = new AddonComponent( 3367 );
			ac.Hue = 2213;
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 3203 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 3367 );
			ac.Hue = 1341;
			AddComponent( ac, 1, -2, 7 );
			ac = new AddonComponent( 3231 );
			ac.Hue = 1341;
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 3203 );
			AddComponent( ac, 0, 0, 8 );
			ac = new AddonComponent( 3203 );
			ac.Hue = 1645;
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 3203 );
			ac.Hue = 2213;
			AddComponent( ac, 1, -1, 10 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 0, -3, 5 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 0, -1, 5 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 5112 );
			ac.Hue = 1753;
			AddComponent( ac, 2, 2, 10 );
			ac = new AddonComponent( 5112 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 2, 4 );
			ac = new AddonComponent( 5112 );
			ac.Hue = 1753;
			AddComponent( ac, 2, 4, 10 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 1, -2, 5 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 1, -1, 5 );
			ac = new AddonComponent( 16382 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 16382 );
			AddComponent( ac, 0, 4, 0 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 1, -3, 5 );
			ac = new AddonComponent( 16382 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4117 );
			ac.Hue = 1753;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 16382 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 5112 );
			ac.Hue = 1753;
			AddComponent( ac, -1, 4, 4 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 0, -2, 5 );
			ac = new AddonComponent( 7592 );
			ac.Hue = 1753;
			AddComponent( ac, 0, 0, 5 );

		}

		public CarrieAnneWagonAddon( Serial serial ) : base( serial )
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

	public class CarrieAnneWagonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CarrieAnneWagonAddon();
			}
		}

		[Constructable]
		public CarrieAnneWagonAddonDeed()
		{
			Name = "CarrieAnneWagon";
		}

		public CarrieAnneWagonAddonDeed( Serial serial ) : base( serial )
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