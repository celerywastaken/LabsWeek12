

//#define SOME_SYMBOL
//#if SOME_SYMBOL
////Symbol is already defined
//#else
////Symbol is undefined 
//#endif

////#undef SOME_SYMBOL
//#if SOME_SYMBOL
////Symbol is already defined
//#else
////Symbol is undefined
//#endif

//#if UNITY_IOS
//    const string dll = "_Internal";
//#else
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;

//const string dll = "MyNAtivePlugin";
//#endif

//[DllImport(dll)]
//private static extern void foo();

//you might check if your game is being played on a console by putting the following at the top of your script:
//#if UNITY_PS4 || UNITY_WII || UNITY_XBOXONE
//#define USING_CONSOLE
//#endif

//you might check for USING_CONSOLE to use the branch of code that defines console controls versus keyboard controls. For example:

//#if USING_CONSOLE
// load console controls
//#else
//load mouse/keyboard controls
//#endif