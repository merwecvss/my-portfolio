document.addEventListener("DOMContentLoaded", function () {
    document.querySelectorAll(".task-select").forEach(cb => {
        cb.addEventListener("change", function () {
            let id = this.getAttribute("data-id");
            let checked = this.checked;

            // satırı bul
            let row = this.closest("tr");
            let statusCell = row.querySelector("td:nth-child(4)"); // 4. sütun Durum

            // Sunucuya isteği gönder
            fetch(`/ToDoList/ChangeToDoListStatus/${id}?status=${checked}`, {
                method: "POST"
            })
                .then(res => {
                    if (res.ok) {
                        // Badge güncelle
                        if (checked) {
                            statusCell.innerHTML = '<span class="badge badge-success">Yapıldı</span>';
                        } else {
                            statusCell.innerHTML = '<span class="badge badge-secondary">Yapılmadı</span>';
                        }
                    } else {
                        alert("Durum güncellenirken hata oluştu.");
                        this.checked = !checked; // hata olursa eski haline dönsün
                    }
                })
                .catch(err => {
                    console.error("Hata:", err);
                    this.checked = !checked;
                });
        });
    });
});
