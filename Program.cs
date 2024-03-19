//TODO connect to neovim rpc and controll some features with it


using NeovimClient;
var nvim = new NeovimClient<NeovimTcp>(new NeovimTcp("127.0.0.1",6666));
Console.WriteLine("Starting ");
nvim.Init();
//nvim.Action("echo", "REEE");
var test = nvim.GetApiInfo();
Console.WriteLine("done?");
Console.WriteLine(test.ToString());
nvim.Dispose();
