#include "Globals.hpp"

namespace Nesae::ExpandedPhotoMode::Globals
{
	KeyBind KeyBindings::RollAdjustUp = { 0x52, L"R" };
	KeyBind KeyBindings::RollAdjustDown = { 0x54, L"T" };

	KeyBind KeyBindings::FoVAdjustUp = { 0x46, L"F" };
	KeyBind KeyBindings::FoVAdjustDown = { 0x47, L"G" };

	KeyBind KeyBindings::Player_XAxisRotationUp = { 0x49, L"I" };
	KeyBind KeyBindings::Player_XAxisRotationDown = { 0x4F, L"O" };
	KeyBind KeyBindings::Player_YAxisRotationUp = { 0x4B, L"K" };
	KeyBind KeyBindings::Player_YAxisRotationDown = { 0x4C, L"L" };
	KeyBind KeyBindings::Player_ZAxisRotationUp = { 0x4E, L"N" };
	KeyBind KeyBindings::Player_ZAxisRotationDown = { 0x4D, L"M" };

	KeyBind KeyBindings::Reset = { 0x51, L"Q" };
	KeyBind KeyBindings::DisableMod = { VK_END, L"END" };

	std::map<DWORD, CameraPosKey> KeyBindings::Camera_PosManageKeys
	{
		{ 0, { { VK_F1, L"F1" }, { 0x31, L"1" }}},
		{ 1, { { VK_F2, L"F2" }, { 0x32, L"2" }}},
		{ 2, { { VK_F3, L"F3" }, { 0x33, L"3" }}},
		{ 3, { { VK_F4, L"F4" }, { 0x34, L"4" }}},
		{ 4, { { VK_F5, L"F5" }, { 0x35, L"5" }}},
		{ 5, { { VK_F6, L"F6" }, { 0x36, L"6" }}},
		{ 6, { { VK_F7, L"F7" }, { 0x37, L"7" }}},
		{ 7, { { VK_F8, L"F8" }, { 0x38, L"8" }}},
		{ 8, { { VK_F9, L"F9" }, { 0x39, L"9" }}},
	};
}