#include <Windows.h>
#include <iostream>
#include <map>

#include "IPhotoMode.hpp"
#include "IPlayer.hpp"
#include "Globals.hpp"

// Expanded Photo Mode mod for Shadow of the Tomb Raider (v1.0 build 458.0_64 - Steam)

using Nesae::ExpandedPhotoMode::Globals::KeyBindings;

void InitalizeConsole()
{
    AllocConsole();
    freopen_s((FILE**)stdout, "CONOUT$", "w", stdout);

    CONSOLE_CURSOR_INFO info{ 100, FALSE };
    SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &info);

    SetConsoleTitle(L"Foundation Game Camera");

    std::wcout << "Expanded Photo Mode mod for Shadow of the Tomb Raider\n\n";
    std::wcout << "Press " << KeyBindings::RollAdjustUp.KeyName << " and " << KeyBindings::RollAdjustDown.KeyName << " to adjust roll\n";
    std::wcout << "Press " << KeyBindings::FoVAdjustUp.KeyName << " and " << KeyBindings::FoVAdjustDown.KeyName << " to adjust fov\n";
    std::wcout << "Press " << KeyBindings::Player_XAxisRotationUp.KeyName << " and " << KeyBindings::Player_YAxisRotationDown.KeyName << " to rotate the player by X axis\n";
    std::wcout << "Press " << KeyBindings::Player_YAxisRotationUp.KeyName << " and " << KeyBindings::Player_YAxisRotationDown.KeyName << " to rotate the player by Y axis\n";
    std::wcout << "Press " << KeyBindings::Player_ZAxisRotationUp.KeyName << " and " << KeyBindings::Player_ZAxisRotationDown.KeyName << " to rotate the player by Z axis\n";
    std::wcout << "Press F1 - F9 to save the camera position\n";
    std::wcout << "Press 1 - 9 to restore the camera position\n";
    std::wcout << "\n";
    std::wcout << "Press " << KeyBindings::DisableMod.KeyName << " to unload while not using the photographer mode.";
}

void UninitializeConsole()
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 0x4);

    std::wcout << "\n\nMod disabled - the console can be closed.";

    FreeConsole();
}

DWORD __stdcall MainThread(HMODULE thisModule)
{
    DisableThreadLibraryCalls(thisModule);
    InitalizeConsole();

    auto iPhotoMode = new Nesae::ExpandedPhotoMode::IPhotoMode;
    auto iPlayer = new Nesae::ExpandedPhotoMode::IPlayer;

    bool initialized = false;

    while (true)
    {
#pragma region Initialization

        if (!initialized && iPhotoMode->IsPhotoMode())
        {
            iPhotoMode->Initialize();
            iPlayer->Initialize();

            initialized = true;
        }
        else if (initialized && !iPhotoMode->IsPhotoMode())
        {
            iPhotoMode->Uninitialize();
            iPlayer->Uninitialize();

            initialized = false;
        }

#pragma endregion

#pragma region Hot Keys

        if (initialized && iPhotoMode->IsPhotoMode())
        {
            if (GetAsyncKeyState(KeyBindings::RollAdjustUp.KeyCode))
                iPhotoMode->ChangeRoll(0.01f);

            if (GetAsyncKeyState(KeyBindings::RollAdjustDown.KeyCode))
                iPhotoMode->ChangeRoll(-0.01f);

            if (GetAsyncKeyState(KeyBindings::FoVAdjustUp.KeyCode))
                iPhotoMode->ChangeFoV(0.01f);

            if (GetAsyncKeyState(KeyBindings::FoVAdjustDown.KeyCode))
                iPhotoMode->ChangeFoV(-0.01f);

            if (GetAsyncKeyState(KeyBindings::Player_XAxisRotationUp.KeyCode))
                iPlayer->Rotate(Nesae::ExpandedPhotoMode::RotationAxis::X, 0.01f);

            if (GetAsyncKeyState(KeyBindings::Player_XAxisRotationDown.KeyCode))
                iPlayer->Rotate(Nesae::ExpandedPhotoMode::RotationAxis::X, -0.01f);

            if (GetAsyncKeyState(KeyBindings::Player_YAxisRotationUp.KeyCode))
                iPlayer->Rotate(Nesae::ExpandedPhotoMode::RotationAxis::Y, 0.01f);

            if (GetAsyncKeyState(KeyBindings::Player_YAxisRotationDown.KeyCode))
                iPlayer->Rotate(Nesae::ExpandedPhotoMode::RotationAxis::Y, -0.01f);

            if (GetAsyncKeyState(KeyBindings::Player_ZAxisRotationUp.KeyCode))
                iPlayer->Rotate(Nesae::ExpandedPhotoMode::RotationAxis::Z, 0.01f);

            if (GetAsyncKeyState(KeyBindings::Player_ZAxisRotationDown.KeyCode))
                iPlayer->Rotate(Nesae::ExpandedPhotoMode::RotationAxis::Z, -0.01f);

            if (GetAsyncKeyState(KeyBindings::Reset.KeyCode)) // Q
            {
                // Game defined reset key

                iPlayer->Restore();
            }

            for (const auto& [index, object] : KeyBindings::Camera_PosManageKeys)
            {
                if (GetAsyncKeyState(object.KeySave.KeyCode))
                {
                    iPhotoMode->SavePosition(index);
                    Beep(500, 100);
                }

                if (GetAsyncKeyState(object.KeyRestore.KeyCode))
                {
                    iPhotoMode->RestorePosition(index);
                    Beep(800, 100);
                }
            }
        }

        if (GetAsyncKeyState(VK_END))
            break;

#pragma endregion

        Sleep(10);
    }

    delete iPhotoMode;
    delete iPlayer;

    UninitializeConsole();
    FreeLibraryAndExitThread(thisModule, 0);
    
    return 0;
}

BOOL __stdcall DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
    switch (ul_reason_for_call)
    {
        case DLL_PROCESS_ATTACH:
        {
            CreateThread(0, 0, (LPTHREAD_START_ROUTINE)MainThread, hModule, 0, 0);
            break;
        }
    }
    return TRUE;
}