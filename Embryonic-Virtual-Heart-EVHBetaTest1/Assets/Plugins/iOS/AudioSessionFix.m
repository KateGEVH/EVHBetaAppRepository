#import <AVFoundation/AVFoundation.h>

// Called from C# via DllImport to override the iOS audio session category.
// Category 1 = AVAudioSessionCategoryPlayback (ignores silent switch).
void UnitySetAudioSessionCategory(int category) {
    NSError *error = nil;
    if (category == 1) {
        [[AVAudioSession sharedInstance] setCategory:AVAudioSessionCategoryPlayback error:&error];
    }
    if (error) {
        NSLog(@"AudioSessionFix: Failed to set audio session category: %@", error.localizedDescription);
    }
    [[AVAudioSession sharedInstance] setActive:YES error:&error];
    if (error) {
        NSLog(@"AudioSessionFix: Failed to activate audio session: %@", error.localizedDescription);
    }
}
