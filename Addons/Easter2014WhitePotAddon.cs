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
	public class Easter2014WhitePotAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Easter2014WhitePotAddonDeed();
			}
		}

		[ Constructable ]
		public Easter2014WhitePotAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4550 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 6809 );
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 3153 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 3208 );
			AddComponent( ac, 0, 0, 4 );

		}

		public Easter2014WhitePotAddon( Serial serial ) : base( serial )
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

	public class Easter2014WhitePotAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Easter2014WhitePotAddon();
			}
		}

		[Constructable]
		public Easter2014WhitePotAddonDeed()
		{
			Name = "Easter2014WhitePot";
		}

		public Easter2014WhitePotAddonDeed( Serial serial ) : base( serial )
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