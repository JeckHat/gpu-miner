namespace OrionClientLib.Pools
{
    public class BitzTrackPool : BitzHQPool
    {
        public override string Name { get; } = "Hatz Mining Pool";
        public override string DisplayName => Name;
        public override bool DisplaySetting => true;
        public override string ArgName => "Hatz Pool";

        public override string Description => $"[green]BITZ[/]. 5% commission. Operators (discord): JeckHat";
        public override Coin Coins { get; } = Coin.Ore;

        public override Dictionary<string, string> Features { get; } = new Dictionary<string, string>();

        public override bool HideOnPoolList { get; } = false;
        public override string HostName { get; protected set; } = "pool.bitztrack.com";

        public override Dictionary<Coin, double> MiniumumRewardPayout => new Dictionary<Coin, double> { { Coin.Ore, 0.05 } };

        public override string Website => "https://pool.bitztrack.com/miner/rewards?pubkey={0}";
        
        public override bool StakingEnabled => true;
    }
}
