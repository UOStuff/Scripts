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
	public class CyborgSuperComputerAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CyborgSuperComputerAddonDeed();
			}
		}

		[ Constructable ]
		public CyborgSuperComputerAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, -2, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 2, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 2, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, -1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, -2, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, 2, 15 );
			ac = new AddonComponent( 3875 );
			AddComponent( ac, 1, 2, 7 );
			ac = new AddonComponent( 3875 );
			AddComponent( ac, 1, 2, 10 );
			ac = new AddonComponent( 3875 );
			AddComponent( ac, 1, 2, 13 );
			ac = new AddonComponent( 3875 );
			AddComponent( ac, 1, 2, 16 );
			ac = new AddonComponent( 3875 );
			AddComponent( ac, 1, 2, 19 );
			ac = new AddonComponent( 4435 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 14270 );
			ac.Hue = 2569;
			AddComponent( ac, 1, 3, 19 );
			ac = new AddonComponent( 3856 );
			AddComponent( ac, 1, -2, 9 );
			ac = new AddonComponent( 3856 );
			AddComponent( ac, 1, -2, 13 );
			ac = new AddonComponent( 3856 );
			AddComponent( ac, 1, -2, 15 );
			ac = new AddonComponent( 3856 );
			AddComponent( ac, 1, -2, 17 );
			ac = new AddonComponent( 3856 );
			AddComponent( ac, 1, -2, 19 );
			ac = new AddonComponent( 3856 );
			AddComponent( ac, 1, -2, 11 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 4 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 12 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 8 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 10 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 14 );
			ac = new AddonComponent( 3865 );
			AddComponent( ac, 1, 1, 2 );
			ac = new AddonComponent( 4242 );
			AddComponent( ac, 1, 1, 20 );
			ac = new AddonComponent( 4240 );
			AddComponent( ac, 1, 0, 8 );
			ac = new AddonComponent( 4239 );
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 7961 );
			ac.Hue = 2982;
			AddComponent( ac, 0, 1, 20 );
			ac = new AddonComponent( 7961 );
			ac.Hue = 2982;
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 7961 );
			ac.Hue = 2982;
			AddComponent( ac, 0, -1, 20 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 2959;
			AddComponent( ac, 0, -2, 15 );
			ac = new AddonComponent( 14270 );
			ac.Hue = 2569;
			AddComponent( ac, 1, -1, 20 );

		}

		public CyborgSuperComputerAddon( Serial serial ) : base( serial )
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

	public class CyborgSuperComputerAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CyborgSuperComputerAddon();
			}
		}

		[Constructable]
		public CyborgSuperComputerAddonDeed()
		{
			Name = "CyborgSuperComputer";
		}

		public CyborgSuperComputerAddonDeed( Serial serial ) : base( serial )
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