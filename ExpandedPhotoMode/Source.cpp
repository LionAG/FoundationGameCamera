#include <Windows.h>
#include <iostream>
#include <map>

#include "IPhotoMode.hpp"

// Expanded Photo Mode mod for Shadow of the Tomb Raider (v1.0 build 458.0_64 - Steam)

void InitalizeConsole()
{
    AllocConsole();
    freopen_s((FILE**)stdout, "CONOUT$", "w", stdout);

    CONSOLE_CURSOR_INFO info{ 100, FALSE };
    SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &info);

    SetConsoleTitle(L"FoundationGameCamera");

    std::wcout << "Expanded Photo Mode mod for Shadow of the Tomb Raider\n\n";
    std::wcout << "Press R and T to adjust roll\n";
    std::wcout << "Press F and G to adjust fov\n";
    std::wcout << "Press F1 - F9 to save the camera position\n";
    std::wcout << "Press 1 - 9 to restore the camera position\n";
    std::wcout << "Press END to unload while not using the photographer mode.";
}

void RemoveConsole()
{
    std::wcout << "\n\nUnloaded";

    FreeConsole();
}

DWORD __stdcall MainThread(HMODULE thisModule)
{
    InitalizeConsole();
    
    struct CameraTeleportKey
    {
        DWORD KeySave;
        DWORD KeyRestore;
    };

    std::map<unsigned int, CameraTeleportKey> camera_pos_keys
    {
        { 0, {VK_F1, 0x31} },
        { 1, {VK_F2, 0x32} },
        { 2, {VK_F3, 0x33} },
        { 3, {VK_F4, 0x34} },
        { 4, {VK_F5, 0x35} },
        { 5, {VK_F6, 0x36} },
        { 6, {VK_F7, 0x37} },
        { 7, {VK_F8, 0x38} },
        { 8, {VK_F9, 0x39} },
    };

    auto iPhotoMode = new Nesae::ExpandedPhotoMode::IPhotoMode;

    while (true)
    {
        if (iPhotoMode->IsPhotoMode())
        {
            if (GetAsyncKeyState(0x52)) // R
                iPhotoMode->ChangeRoll(0.01f);

            if (GetAsyncKeyState(0x54)) // T
                iPhotoMode->ChangeRoll(-0.01f);

            if (GetAsyncKeyState(0x46)) // F
                iPhotoMode->ChangeFoV(0.01f);

            if (GetAsyncKeyState(0x47)) // G
                iPhotoMode->ChangeFoV(-0.01f);

            for (auto& [key, value] : camera_pos_keys)
            {
                if (GetAsyncKeyState(value.KeySave))
                {
                    iPhotoMode->SavePosition(key);
                    Beep(500, 100);
                }

                if (GetAsyncKeyState(value.KeyRestore))
                {
                    iPhotoMode->RestorePosition(key);
                    Beep(800, 100);
                }
            }
        }

        if (GetAsyncKeyState(VK_END))
            break;

        Sleep(10);
    }

    delete iPhotoMode;

    RemoveConsole();
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