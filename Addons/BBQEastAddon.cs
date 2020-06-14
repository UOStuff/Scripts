/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BBQ1EastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BBQ1EastAddonDeed();
			}
		}

		[ Constructable ]
		public BBQ1EastAddon()
		{
			AddComponent( new AddonComponent( 2449 ), 1, 2, 7 );
			AddComponent( new AddonComponent( 1822 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 1822 ), 1, 2, 2 );
			AddComponent( new AddonComponent( 5111 ), 1, 2, 9 );
			AddComponent( new AddonComponent( 3530 ), 1, 1, 6 );
			AddComponent( new AddonComponent( 7703 ), 1, 1, 7 );
			AddComponent( new AddonComponent( 4846 ), 1, 1, 5 );
			AddComponent( new AddonComponent( 1822 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 5637 ), 0, -3, 7 );
			AddComponent( new AddonComponent( 1822 ), 0, -3, 3 );
			AddComponent( new AddonComponent( 5625 ), 0, -2, 9 );
			AddComponent( new AddonComponent( 1822 ), 0, -2, 4 );
			AddComponent( new AddonComponent( 1822 ), 0, -1, 6 );
			AddComponent( new AddonComponent( 2459 ), 0, -1, 11 );
			AddComponent( new AddonComponent( 1822 ), 0, -1, 2 );
			AddComponent( new AddonComponent( 5634 ), 0, 0, 11 );
			AddComponent( new AddonComponent( 1822 ), 0, 0, 6 );
			AddComponent( new AddonComponent( 1822 ), 0, 0, 2 );
			AddComponent( new AddonComponent( 3530 ), 1, 0, 6 );
			AddComponent( new AddonComponent( 7703 ), 1, 0, 7 );
			AddComponent( new AddonComponent( 4846 ), 1, 0, 5 );
			AddComponent( new AddonComponent( 1822 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 6467 ), 1, -1, 4 );
			AddComponent( new AddonComponent( 1822 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 1822 ), 1, -1, 2 );
			AddComponent( new AddonComponent( 5628 ), 0, 1, 9 );
			AddComponent( new AddonComponent( 1822 ), 0, 1, 4 );
			AddComponent( new AddonComponent( 2518 ), 0, 2, 8 );
			AddComponent( new AddonComponent( 1822 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 1822 ), 0, 2, 3 );
			AddComponent( new AddonComponent( 2421 ), 1, -2, 6 );
			AddComponent( new AddonComponent( 4846 ), 1, -2, 5 );
			AddComponent( new AddonComponent( 3530 ), 1, -2, 6 );
			AddComponent( new AddonComponent( 2416 ), 1, -2, 14 );
			AddComponent( new AddonComponent( 1822 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 4329 ), 1, -3, 7 );
			AddComponent( new AddonComponent( 1822 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 1822 ), 1, -3, 2 );
			AddComponent( new AddonComponent( 7138 ), 1, 3, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 5625 );
			AddComponent( ac, 0, -2, 9 );
            ac = new AddonComponent( 7138 );
            ac.Name = "Mesquite Logs";
            AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 5628 );
			AddComponent( ac, 0, 1, 9 );
			ac = new AddonComponent( 5634 );
			AddComponent( ac, 0, 0, 11 );
			ac = new AddonComponent( 5637 );
			AddComponent( ac, 0, -3, 7 );
            ac = new AddonComponent( 4846 );
            ac.Light = LightType.Circle225;
            AddComponent( ac, 1, 1, 5 );
            ac = new AddonComponent( 4846 );
            ac.Light = LightType.Circle225;
            AddComponent( ac, 1, 0, 5 );
            ac = new AddonComponent( 4846 );
            ac.Light = LightType.Circle225;
            AddComponent( ac, 1, -2, 5 );
			ac = new AddonComponent( 2518 );
			ac.Name = "Marinade";
			AddComponent( ac, 0, 2, 8 );
            ac = new AddonComponent( 6467 );
            ac.Name = "Imported Spices";
            AddComponent( ac, 1, -1, 4 );
            ac = new AddonComponent( 3530 );
            ac.Hue = 1;
            ac.Name = "Grill";
            AddComponent( ac, 1, 1, 6 );
            ac = new AddonComponent( 3530 );
            ac.Hue = 1;
            ac.Name = "Grill";
            AddComponent( ac, 1, 0, 6 );
            ac = new AddonComponent( 3530 );
            ac.Hue = 1;
            ac.Name = "Grill";
            AddComponent( ac, 1, -2, 6 );
            ac = new AddonComponent( 7703 );
            ac.Name = "Grilled Salmon";
            AddComponent( ac, 1, 1, 7 );
            ac = new AddonComponent( 7703 );
            ac.Name = "Grilled Salmon";
            AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, -1, 6 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 2459 );
			ac.Name = "Cooking Wine";
			AddComponent( ac, 0, -1, 11 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, -3, 3 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, -2, 4 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, 1, 4 );
			ac = new AddonComponent( 1822 );
			AddComponent( ac, 0, 2, 3 );

		}

		public BBQ1EastAddon( Serial serial ) : base( serial )
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

	public class BBQ1EastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BBQ1EastAddon();
			}
		}

		[Constructable]
		public BBQ1EastAddonDeed()
		{
			Name = "BBQ1East";
		}

		public BBQ1EastAddonDeed( Serial serial ) : base( serial )
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