﻿using UnityEngine;
using System;
using System.Collections;

public class MethodCall {
	
	public string id;
	public string methodName;
	public JSONObject[] items;

	public bool hasUpdated;
	public Action<MethodCall> OnUpdated;

	public JSONObject result;
	public bool hasResult;
	public Action<MethodCall> OnResult;

	public DdpError error;
}
