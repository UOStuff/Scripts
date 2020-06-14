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
	public class AsianPlastCornNWRedAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AsianPlastCornNWRedAddonDeed();
			}
		}

		[ Constructable ]
		public AsianPlastCornNWRedAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9384 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 9193 );
			AddComponent( ac, 0, 0, 17 );
			ac = new AddonComponent( 9189 );
			AddComponent( ac, 0, 1, 17 );
			ac = new AddonComponent( 9191 );
			AddComponent( ac, 1, 0, 17 );
			ac = new AddonComponent( 9187 );
			AddComponent( ac, 1, 1, 17 );
			ac = new AddonComponent( 9374 );
			ac.Hue = 2107;
			AddComponent( ac, 0, 0, 0 );

		}

		public AsianPlastCornNWRedAddon( Serial serial ) : base( serial )
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

	public class AsianPlastCornNWRedAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AsianPlastCornNWRedAddon();
			}
		}

		[Constructable]
		public AsianPlastCornNWRedAddonDeed()
		{
			Name = "AsianPlastCornNWRed";
		}

		public AsianPlastCornNWRedAddonDeed( Serial serial ) : base( serial )
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