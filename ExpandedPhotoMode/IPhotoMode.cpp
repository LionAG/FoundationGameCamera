#include "IPhotoMode.hpp"
#include <Windows.h>

void Nesae::ExpandedPhotoMode::IPhotoMode::EnableOverride()
{
    // Go to any distance

    auto data = new byte[6];
    memset(data, 0x90, 6);

    auto coordinateX = (QWORD)GetModuleHandle(NULL) + 0x8CB655;
    auto coordinateY = (QWORD)GetModuleHandle(NULL) + 0x8CB65B;
    auto coordinateZ = (QWORD)GetModuleHandle(NULL) + 0x8CB695;

    DWORD oldProtect, sOldProtect;
    VirtualProtect((LPVOID)coordinateX, 0x1000, PAGE_READWRITE, &oldProtect);

    memcpy((void*)coordinateX, data, 6);
    memcpy((void*)coordinateY, data, 6);
    memcpy((void*)coordinateZ, data, 6);

    // According to documentation this function fails if lpflOldProtect is NULL.
    VirtualProtect((LPVOID)coordinateX, 0x1000, oldProtect, &sOldProtect);

    delete[] data;

    overrideEnabled = true;
}

void Nesae::ExpandedPhotoMode::IPhotoMode::DisableOverride()
{
    auto coordinateX = (QWORD)GetModuleHandle(NULL) + 0x8CB655;
    auto coordinateY = (QWORD)GetModuleHandle(NULL) + 0x8CB65B;
    auto coordinateZ = (QWORD)GetModuleHandle(NULL) + 0x8CB695;

    byte dataX[6] = { 0xF3, 0x0F, 0x11, 0x44, 0x24, 0x30 };
    byte dataY[6] = { 0xF3, 0x0F, 0x11, 0x4C, 0x24, 0x34 };
    byte dataZ[6] = { 0xF3, 0x0F, 0x11, 0x4C, 0x24, 0x38 };

    DWORD oldProtect, sOldProtect;
    VirtualProtect((LPVOID)coordinateX, 0x1000, PAGE_READWRITE, &oldProtect);

    memcpy((void*)coordinateX, dataX, sizeof(dataX));
    memcpy((void*)coordinateY, dataY, sizeof(dataY));
    memcpy((void*)coordinateZ, dataZ, sizeof(dataZ));

    VirtualProtect((LPVOID)coordinateX, 0x1000, oldProtect, &sOldProtect);

    overrideEnabled = false;
}

Nesae::ExpandedPhotoMode::IPhotoMode::IPhotoMode()
{
    // Initialize to default (0,0,0) position

    for (auto& pos : this->SavedPosition)
    {
        pos.x = 0;
        pos.y = 0;
        pos.z = 0;
    }
}

Nesae::ExpandedPhotoMode::IPhotoMode::~IPhotoMode()
{
    if(this->overrideEnabled)
        DisableOverride();
}

bool Nesae::ExpandedPhotoMode::IPhotoMode::IsPhotoMode()
{
    // Check if photographer mode is enabled by checking if the address of PhotoModeCameraController instance != nullptr

    return (GetCameraInstance() != nullptr);
}

Nesae::ExpandedPhotoMode::SDK::PhotoModeCameraController* Nesae::ExpandedPhotoMode::IPhotoMode::GetCameraInstance()
{
    auto moduleBase = (QWORD)GetModuleHandle(NULL);
    auto pointerBase = *((QWORD*)(moduleBase + 0x36A76C0));
    auto instance = *((QWORD*)(pointerBase + 0x48));

    return reinterpret_cast<SDK::PhotoModeCameraController*>(instance);
}

void Nesae::ExpandedPhotoMode::IPhotoMode::ChangeRoll(float amount)
{
    auto roll = this->GetCameraInstance()->Roll;
    
    roll += amount;

    // This should allow going on an infinite 'circle loop' by holding roll change key

    if (roll > 3.14f)
        roll = -3.14f;

    if (roll < -3.14f)
        roll = 3.14f;

    this->GetCameraInstance()->Roll = roll;
}

void Nesae::ExpandedPhotoMode::IPhotoMode::ChangeFoV(float amount)
{
    auto fov = this->GetCameraInstance()->FoV;

    fov += amount;

    if (fov > 1.308f)
        fov = 1.308f;

    if (fov < 0.05f)
        fov = 0.1f;

    this->GetCameraInstance()->FoV = fov;
}

void Nesae::ExpandedPhotoMode::IPhotoMode::SavePosition(int index)
{
    auto instance = this->GetCameraInstance();

    this->SavedPosition[index].x = instance->X;
    this->SavedPosition[index].y = instance->Y;
    this->SavedPosition[index].z = instance->Z;
}

void Nesae::ExpandedPhotoMode::IPhotoMode::RestorePosition(int index)
{
    auto instance = this->GetCameraInstance();

    instance->X = this->SavedPosition[index].x;
    instance->Y = this->SavedPosition[index].y;
    instance->Z = this->SavedPosition[index].z;
}

void Nesae::ExpandedPhotoMode::IPhotoMode::Initialize()
{
    EnableOverride();

    auto instance = this->GetCameraInstance();

    for (auto& pos : this->SavedPosition)
    {
        pos.x = instance->X;
        pos.y = instance->Y;
        pos.z = instance->Z;
    }

    initialized = true;
}

void Nesae::ExpandedPhotoMode::IPhotoMode::Uninitialize()
{
    DisableOverride();

    for (auto& pos : this->SavedPosition)
    {
        pos.x = 0;
        pos.y = 0;
        pos.z = 0;
    }

    initialized = false;
}

bool Nesae::ExpandedPhotoMode::IPhotoMode::IsInitialized()
{
    return this->initialized;
}
