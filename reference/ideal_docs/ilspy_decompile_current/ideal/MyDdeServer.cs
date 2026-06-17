using System.Runtime.CompilerServices;
using NDde.Server;
using dg3ypDAonQcOidMs0w;

namespace ideal;

public class MyDdeServer : DdeServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MyDdeServer(string service)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Register()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Unregister()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool OnStartAdvise(DdeConversation conversation, string item, int format)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnStopAdvise(DdeConversation conversation, string item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ExecuteResult OnExecute(DdeConversation conversation, string command)
	{
		return (ExecuteResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override PokeResult OnPoke(DdeConversation conversation, string item, byte[] data, int format)
	{
		return (PokeResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override RequestResult OnRequest(DdeConversation conversation, string item, int format)
	{
		return (RequestResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override byte[] OnAdvise(string topic, string item, int format)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MyDdeServer()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
