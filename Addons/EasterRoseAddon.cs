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
	public class EasterRoseAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new EasterRoseAddonDeed();
			}
		}

		[ Constructable ]
		public EasterRoseAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2886 );
			ac.Hue = 2931;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 9035 );
			AddComponent( ac, 0, 0, 7 );

		}

		public EasterRoseAddon( Serial serial ) : base( serial )
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

	public class EasterRoseAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new EasterRoseAddon();
			}
		}

		[Constructable]
		public EasterRoseAddonDeed()
		{
			Name = "EasterRose";
		}

		public EasterRoseAddonDeed( Serial serial ) : base( serial )
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