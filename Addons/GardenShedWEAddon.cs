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
	public class GardenShedWEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GardenShedWEAddonDeed();
			}
		}

		[ Constructable ]
		public GardenShedWEAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1303 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 8 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1303 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1303 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 8 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1303 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1303 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 8 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1303 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1303 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 9 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 7 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1351 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1349 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1345 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 6 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1303 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1344 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 3897 );
			ac.Hue = 2419;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1355 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1345 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 2, 0, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, -2, 0, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, -1, 0, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 2, 0, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, -2, -1, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, -1, -2, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 0, -2, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 1, -2, 20 );
			ac = new AddonComponent( 22 );
			AddComponent( ac, 2, -2, 20 );
			ac = new AddonComponent( 21 );
			AddComponent( ac, 2, -1, 20 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, 0, -1, 20 );
			ac = new AddonComponent( 9994 );
			AddComponent( ac, 1, -2, 20 );
			ac = new AddonComponent( 9993 );
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 9994 );
			AddComponent( ac, 2, -2, 20 );
			ac = new AddonComponent( 9992 );
			AddComponent( ac, 1, -1, 22 );
			ac = new AddonComponent( 9992 );
			AddComponent( ac, 2, -1, 22 );
			ac = new AddonComponent( 9992 );
			AddComponent( ac, 0, -1, 22 );
			ac = new AddonComponent( 9993 );
			AddComponent( ac, 2, 0, 20 );
			ac = new AddonComponent( 9994 );
			AddComponent( ac, -1, -2, 20 );
			ac = new AddonComponent( 9994 );
			AddComponent( ac, 0, -2, 20 );
			ac = new AddonComponent( 9993 );
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 9993 );
			AddComponent( ac, -1, 0, 20 );
			ac = new AddonComponent( 9992 );
			AddComponent( ac, -1, -1, 22 );

		}

		public GardenShedWEAddon( Serial serial ) : base( serial )
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

	public class GardenShedWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GardenShedWEAddon();
			}
		}

		[Constructable]
		public GardenShedWEAddonDeed()
		{
			Name = "GardenShedWE";
		}

		public GardenShedWEAddonDeed( Serial serial ) : base( serial )
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