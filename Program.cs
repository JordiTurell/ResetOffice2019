List<string> commands = new List<string>();
commands.Add("cd /d %ProgramFiles%\\Microsoft Office\\Office16");
commands.Add("cd /d %ProgramFiles(x86)%\\Microsoft Office\\Office16");
commands.Add("for /f %x in ('dir /b ..\\root\\Licenses16\\ProPlus2019VL*.xrm-ms') do cscript ospp.vbs /inslic:\"..\\root\\Licenses16\\%x\"");
commands.Add("cscript ospp.vbs /setprt:1688");
commands.Add("cscript ospp.vbs /unpkey:6MWKP >nul");
commands.Add("cscript ospp.vbs /inpkey:NMMKJ-6RK4F-KMJVX-8D9MJ-6MWKP");
commands.Add("cscript ospp.vbs /sethst:e8.us.to");
commands.Add("cscript ospp.vbs /act");

foreach(string comand in commands)
{
    Console.WriteLine(comand);
}