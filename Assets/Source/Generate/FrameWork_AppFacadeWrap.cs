﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FrameWork_AppFacadeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FrameWork.AppFacade), typeof(Utility.Singleton<FrameWork.AppFacade>));
		L.RegFunction("SetupManager", SetupManager);
		L.RegFunction("InitAllManager", InitAllManager);
		L.RegFunction("DestroyAllManager", DestroyAllManager);
		L.RegFunction("New", _CreateFrameWork_AppFacade);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("LuaMgr", get_LuaMgr, null);
		L.RegVar("MonoMgr", get_MonoMgr, null);
		L.RegVar("JsonDataMgr", get_JsonDataMgr, null);
		L.RegVar("EventMgr", get_EventMgr, null);
		L.RegVar("ResMgr", get_ResMgr, null);
		L.RegVar("DelayMgr", get_DelayMgr, null);
		L.RegVar("ScenesMgr", get_ScenesMgr, null);
		L.RegVar("UIMgr", get_UIMgr, null);
		L.RegVar("PoolMgr", get_PoolMgr, null);
		L.RegVar("MusicMgr", get_MusicMgr, null);
		L.RegVar("InputMgr", get_InputMgr, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFrameWork_AppFacade(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FrameWork.AppFacade obj = new FrameWork.AppFacade();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FrameWork.AppFacade.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetupManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FrameWork.AppFacade obj = (FrameWork.AppFacade)ToLua.CheckObject<FrameWork.AppFacade>(L, 1);
			obj.SetupManager();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitAllManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FrameWork.AppFacade obj = (FrameWork.AppFacade)ToLua.CheckObject<FrameWork.AppFacade>(L, 1);
			obj.InitAllManager();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyAllManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FrameWork.AppFacade obj = (FrameWork.AppFacade)ToLua.CheckObject<FrameWork.AppFacade>(L, 1);
			obj.DestroyAllManager();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LuaMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.LuaMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MonoMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.MonoMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_JsonDataMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.JsonDataMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EventMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.EventMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ResMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.ResMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DelayMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.DelayMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ScenesMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.ScenesMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UIMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.UIMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PoolMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.PoolMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MusicMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.MusicMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_InputMgr(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, FrameWork.AppFacade.InputMgr);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

