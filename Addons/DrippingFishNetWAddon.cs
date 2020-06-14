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
	public class DrippingFishNetWAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DrippingFishNetWAddonDeed();
			}
		}

		[ Constructable ]
		public DrippingFishNetWAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 7834 );
			AddComponent( ac, -1, -1, 2 );
			ac = new AddonComponent( 2969 );
			AddComponent( ac, -1, -1, 2 );
			ac = new AddonComponent( 9 );
			AddComponent( ac, -1, 0, 2 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, -1, 0, 22 );
			ac = new AddonComponent( 7844 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 6055 );
			AddComponent( ac, 2, 1, 4 );
			ac = new AddonComponent( 6056 );
			AddComponent( ac, 1, 1, 4 );
			ac = new AddonComponent( 6053 );
			AddComponent( ac, 2, 0, 4 );
			ac = new AddonComponent( 6054 );
			AddComponent( ac, 1, 0, 4 );

		}

		public DrippingFishNetWAddon( Serial serial ) : base( serial )
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

	public class DrippingFishNetWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DrippingFishNetWAddon();
			}
		}

		[Constructable]
		public DrippingFishNetWAddonDeed()
		{
			Name = "DrippingFishNetW";
		}

		public DrippingFishNetWAddonDeed( Serial serial ) : base( serial )
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