#pragma once

#include <Windows.h>

#include <string>
#include <map>

namespace Nesae::ExpandedPhotoMode::Globals
{
	struct KeyBind
	{
		DWORD KeyCode;
		std::wstring KeyName;
	};

	struct CameraPosKey
	{
		KeyBind KeySave;
		KeyBind KeyRestore;
	};

	struct KeyBindings
	{
		static KeyBind RollAdjustUp;
		static KeyBind RollAdjustDown;

		static KeyBind FoVAdjustUp;
		static KeyBind FoVAdjustDown;

		static KeyBind Player_XAxisRotationUp;
		static KeyBind Player_XAxisRotationDown;
		static KeyBind Player_YAxisRotationUp;
		static KeyBind Player_YAxisRotationDown;
		static KeyBind Player_ZAxisRotationUp;
		static KeyBind Player_ZAxisRotationDown;

		static KeyBind Reset;
		static KeyBind DisableMod;

		static std::map<DWORD, CameraPosKey> Camera_PosManageKeys;
	};
}