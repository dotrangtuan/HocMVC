public class PlanetService : List<PlanetModel>
{
    public PlanetService()
    {
        AddRange(
            new PlanetModel[] {
                new PlanetModel()
                {
                    Id = 1,
                    Name = "Mercury",
                    VnName = "Sao Thủy",
                    Content = "Sao Thủy (tiếng Anh: Mercury) hay Thủy Tinh (chữ Hán: 水星) là hành tinh nhỏ nhất và gần Mặt Trời nhất trong tám hành tinh thuộc hệ Mặt Trời, với chu kỳ quỹ đạo bằng khoảng 88 ngày Trái Đất. Nhìn từ Trái Đất, hành tinh hiện lên với chu kỳ giao hội trên quỹ đạo bằng xấp xỉ 116 ngày, và nhanh hơn hẳn những hành tinh khác. Tốc độ chuyển động nhanh này đã khiến người La Mã đặt tên hành tinh là Mercurius, vị thần liên lạc và đưa tin một cách nhanh chóng. Trong thần thoại Hy Lạp tên của vị thần này là Hermes (Ερμής). Tên tiếng Việt của hành tinh này dựa theo tên do Trung Quốc đặt, chọn theo hành thủy trong ngũ hành."
                },
                new PlanetModel() {Id = 2, Name = "Earth", Content = "abc", VnName = "Trái Đất"},
                new PlanetModel() {Id = 3, Name = "Jupiter", Content = "abc" , VnName = "Sao Db"},
                new PlanetModel() {Id = 4, Name = "Mars", Content = "abc", VnName = "Sao Db"},
                new PlanetModel() {Id = 5, Name = "Neptune", Content = "abc", VnName = "Sao Db"},
                new PlanetModel() {Id = 6, Name = "Saturn", Content = "abc", VnName = "Sao Db"},
                new PlanetModel() {Id = 7, Name = "Uranus", Content = "abc", VnName = "Sao Db"},
            }
        );
    }
}