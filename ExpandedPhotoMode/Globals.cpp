#include "Globals.hpp"

namespace Nesae::ExpandedPhotoMode::Globals
{
	KeyBind KeyBindings::RollAdjustUp = { 0x52, L"R" };
	KeyBind KeyBindings::RollAdjustDown = { 0x54, L"T" };

	// TODO: Set proper keys

	KeyBind KeyBindings::FoVAdjustUp = { 0x0, L"FoV_UP" };
	KeyBind KeyBindings::FoVAdjustDown = { 0x0, L"FoV_DOWN" };

	KeyBind KeyBindings::Player_XAxisRotationUp = { 0x0, L"X_UP" };
	KeyBind KeyBindings::Player_XAxisRotationDown = { 0x0, L"X_DOWN" };
	KeyBind KeyBindings::Player_YAxisRotationUp = { 0x0, L"Y_UP" };
	KeyBind KeyBindings::Player_YAxisRotationDown = { 0x0, L"Y_DOWN" };
	KeyBind KeyBindings::Player_ZAxisRotationUp = { 0x0, L"Z_UP" };
	KeyBind KeyBindings::Player_ZAxisRotationDown = { 0x0, L"Z_DOWN" };

	std::map<DWORD, CameraPosKey> KeyBindings::Camera_PosManageKeys
	{
		{ 0, { { VK_F1, L"F1" }, { 0x31, L"1" }}}, // {VK_F1, 0x31}
		{ 1, { { VK_F2, L"F2" }, { 0x32, L"2" }}}, // {VK_F2, 0x32}
		{ 2, {VK_F3, 0x33} },
		{ 3, {VK_F4, 0x34} },
		{ 4, {VK_F5, 0x35} },
		{ 5, {VK_F6, 0x36} },
		{ 6, {VK_F7, 0x37} },
		{ 7, {VK_F8, 0x38} },
		{ 8, {VK_F9, 0x39} },
	};
}