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
	public class Hall2012HangingTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2012HangingTreeAddonDeed();
			}
		}

		[ Constructable ]
		public Hall2012HangingTreeAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 7417 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 7416 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 7415 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 7414 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 7413 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 7419 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 7418 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 7433 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 7432 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 7431 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 7412 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 7420 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 7434 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 7441 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 7440 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7430 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 7411 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 7421 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 7435 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 7442 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7439 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 7429 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 7410 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 7422 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 7436 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 7437 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 7438 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 7428 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 7409 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 7423 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 7424 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 7425 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 7426 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 7427 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 4797 );
			ac.Hue = 2306;
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 4796 );
			ac.Hue = 2306;
			AddComponent( ac, 4, -1, 10 );
			ac = new AddonComponent( 4795 );
			ac.Hue = 2306;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 4794 );
			ac.Hue = 2306;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4793 );
			ac.Hue = 2306;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4792 );
			ac.Hue = 2306;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 4791 );
			ac.Hue = 2306;
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 6942 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 7039 );
			AddComponent( ac, -1, 2, 20 );
			ac = new AddonComponent( 7037 );
			AddComponent( ac, 1, 0, 20 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -1, 2, 35 );
			ac = new AddonComponent( 4285 );
			AddComponent( ac, -1, 2, 35 );
			ac = new AddonComponent( 4286 );
			AddComponent( ac, 0, 1, 35 );
			ac = new AddonComponent( 4287 );
			AddComponent( ac, 1, 0, 35 );
			ac = new AddonComponent( 4288 );
			AddComponent( ac, 2, -1, 35 );
			ac = new AddonComponent( 4289 );
			AddComponent( ac, 3, -2, 35 );

		}

		public Hall2012HangingTreeAddon( Serial serial ) : base( serial )
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

	public class Hall2012HangingTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2012HangingTreeAddon();
			}
		}

		[Constructable]
		public Hall2012HangingTreeAddonDeed()
		{
			Name = "Hall2012HangingTree";
		}

		public Hall2012HangingTreeAddonDeed( Serial serial ) : base( serial )
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