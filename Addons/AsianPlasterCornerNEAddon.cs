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
	public class AsianPlasterCornerNEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AsianPlasterCornerNEAddonDeed();
			}
		}

		[ Constructable ]
		public AsianPlasterCornerNEAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9383 );
			ac.Hue = 1807;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 9164 );
			AddComponent( ac, 0, 1, 17 );
			ac = new AddonComponent( 9162 );
			AddComponent( ac, 1, 1, 17 );
			ac = new AddonComponent( 9168 );
			AddComponent( ac, 0, 0, 17 );
			ac = new AddonComponent( 9166 );
			AddComponent( ac, 1, 0, 17 );
			ac = new AddonComponent( 9373 );
			ac.Hue = 1807;
			AddComponent( ac, 1, 0, 0 );

		}

		public AsianPlasterCornerNEAddon( Serial serial ) : base( serial )
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

	public class AsianPlasterCornerNEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AsianPlasterCornerNEAddon();
			}
		}

		[Constructable]
		public AsianPlasterCornerNEAddonDeed()
		{
			Name = "AsianPlasterCornerNE";
		}

		public AsianPlasterCornerNEAddonDeed( Serial serial ) : base( serial )
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