﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Utility_UtilsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Utils");
		L.RegFunction("IsSubClassOf", IsSubClassOf);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsSubClassOf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			object arg0 = ToLua.ToVarObject(L, 1);
			System.Type arg1 = ToLua.CheckMonoType(L, 2);
			bool o = Utility.Utils.IsSubClassOf(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

